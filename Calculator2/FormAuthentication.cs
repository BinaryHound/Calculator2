﻿using Calculator2;
using Calculator2.API_Models;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskShell
{
    public partial class FormAuthentication : Form
    {
        bool TogMove;
        int MValX;
        int MValY;

        public FormAuthentication()
        {
            InitializeComponent();
        }

        private void LaunchMainApplication()
        {
            this.Hide();
            DeskShell mainProgram = new DeskShell();
            mainProgram.Show();

        }

        private void KillApplication()
        {
            this.Close();
            
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            KillApplication();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LaunchMainApplication();
        }

        private void pnlControlsResize_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pnlControlsResize_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void pnlControlsResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void lblGuestLogin_Click(object sender, EventArgs e)
        {
            LaunchMainApplication();
        }

        private void lblGuestLogin_MouseHover(object sender, EventArgs e)
        {
            lblGuestLogin.ForeColor = Color.LightGray;
        }

        private void lblGuestLogin_MouseLeave(object sender, EventArgs e)
        {
            lblGuestLogin.ForeColor = Color.White;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.pnlSignUp.BringToFront();
            this.pnlLoginLeftSide.Hide();
            this.pnlSignUp.Show();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.pnlLoginLeftSide.BringToFront();
            this.pnlSignUp.Hide();
            this.pnlLoginLeftSide.Show();
        }

        private void btnSubmit_Register_Click(object sender, EventArgs e)
        {
            var validationMessage = ValidateUserRegistration();
            if (!validationMessage.Equals(string.Empty))
            {
                MessageBox.Show(validationMessage);
                return;
            }

            var result = DeskShellAPI.Register(new User
            {
                Username = StringMethods.Encode(txtSignUpEmail.Text.Trim()),
                Password = StringMethods.Encode(txtSignUpPassword.Text),
                FirstName = StringMethods.Encode(txtSignUpFirstName.Text.Trim()),
                LastName = StringMethods.Encode(txtSignUpLastName.Text.Trim())
            });
        }

        // Returns string.empty if valid
        private string ValidateUserRegistration()
        {
            // VERY basic validation for now. Need to validate email, lengths (min and max), pw validation, etc
            if (string.IsNullOrWhiteSpace(txtSignUpFirstName.Text))
                return "Invalid First Name";
            if (string.IsNullOrWhiteSpace(txtSignUpLastName.Text))
                return "Invalid Last Name";
            if (string.IsNullOrWhiteSpace(txtSignUpEmail.Text))
                return "Invalid Email";
            if (string.IsNullOrWhiteSpace(txtSignUpPassword.Text))
                return "Invalid Password";
            if (!txtSignUpPassword.Text.Equals(txtSignUpConfirmPassword.Text))
                return "Passwords do not Match";

            return string.Empty;
        }
    }
}

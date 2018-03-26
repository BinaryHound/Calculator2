using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DeskShell;

namespace AuthenticationForm
{
    public partial class FormAuthentication : Form
    {

        #region FieldInitialization

        //Pattern for Regex.
        Regex regexPatternInstance = new Regex(regexPattern);
        const string regexPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$";

        //For the pnl under user to display if the input is correct.
        const int colorCorrectr = 68;
        const int colorCorrectg = 183;
        const int colorCorrectb = 135;

        //For the pnl under the user to display if the input is in-correct.
        const int colorIncorrectr = 252;
        const int colorIncorrectg = 222;
        const int colorIncorrectb = 63;

        bool TogMove;
        int MValX;
        int MValY;
        #endregion

        public FormAuthentication()
        {
            InitializeComponent();
        }

        private void LaunchMainApplication()
        {
            this.Hide();
            var form2 = new MainApplication();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
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
            var validationMessage = ValidateLogin();
            if (!validationMessage.Equals(string.Empty))
            {
                MessageBox.Show(validationMessage);
                return;
            }

            var result = new UIController().Login(txtLogin.Text.Trim(), txtPassword.Text);

            if (result.Equals(string.Empty))
            {
                LaunchMainApplication();
            }
            else
            {
                MessageBox.Show(result);
            }
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //TODO: make sure the validation is working. Cashe's way of doing it.
        // Returns string.empty if valid
        private string ValidateUserRegistration()
        {
            // TODO: VERY basic validation for now. Need to validate email, lengths (min and max), pw validation, etc
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

        private string ValidateLogin()
        {
            // TODO: VERY basic validation for now
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
                return "Invalid Login";
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                return "Invalid Password";

            return string.Empty;
        }

        private void btnSignUpSubmit_Click(object sender, EventArgs e)
        {
            var validationMessage = ValidateUserRegistration();
            if (!validationMessage.Equals(string.Empty))
            {
                MessageBox.Show(validationMessage);
                return;
            }

            var result = new UIController().Register(txtSignUpEmail.Text.Trim(), txtSignUpPassword.Text, txtSignUpFirstName.Text.Trim(), txtSignUpLastName.Text.Trim());

            if (result.Equals(string.Empty))
            {
                MessageBox.Show("Succesfully Created New User");
                btnBackToLogin.PerformClick();
            }
            else
            {
                MessageBox.Show(result);
                return;
            }
        }

        private bool isValidEmail(object sender, EventArgs e)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(((TextBox)sender).Text.Trim());
                return addr.Address == ((TextBox)sender).Text.Trim();
            } catch (Exception ex)
            {
                return false;
            }
        }

        private bool isValidPassword(object sender, EventArgs e)
        {
            //TODO: Make sure that the password is valid.
            if (regexPatternInstance.IsMatch(((TextBox)sender).Text))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks the login textbox to see if the user has input a valid E-mail, and changes colors appropriately.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (isValidEmail(sender, e))
            {
                pnlUnderlineUser.BackColor = Color.FromArgb(colorCorrectr, colorCorrectg, colorCorrectb);
            } else if (((TextBox)sender).Text.Trim().Length == 0)
            {
                pnlUnderlineUser.BackColor = Color.White;
            }else
            {
                pnlUnderlineUser.BackColor = Color.Coral;
            }
        }

        /// <summary>
        /// Changes the color of the password field to show user if input is entered. Kept vague to disuade info leaking to password hackers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                pnlUnderlinePassword.BackColor = Color.FromArgb(colorCorrectr, colorCorrectg, colorCorrectb);
            } else
            {
                pnlUnderlinePassword.BackColor = Color.White;
            }
        }

        private void txtSignUpPassword_TextChanged(object sender, EventArgs e)
        {
            if(isValidPassword(sender, e))
            {
                pnlUnderlinePass.BackColor = Color.FromArgb(colorCorrectr, colorCorrectg, colorCorrectb);
            } else
            {
                pnlUnderlinePass.BackColor = Color.Coral;
            }
            
        }

        private void txtSignUpConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            //TODO: Make sure that the first password is the same as the last password.
            if(txtSignUpPassword.Text == txtSignUpConfirmPassword.Text)
            {
                pnlConfirmPasswordUnderline.BackColor = Color.FromArgb(colorCorrectr, colorCorrectg, colorCorrectb);
            } else
            {
                pnlConfirmPasswordUnderline.BackColor = Color.Coral;
            }
        }

        private void txtSignUpFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtSignUpFirstName.Text.Length > 0)
            {
                pnlSignUpFirstNameUnderline.BackColor = Color.FromArgb(colorCorrectr, colorCorrectg, colorCorrectb);
            } else
            {
                pnlSignUpFirstNameUnderline.BackColor = Color.White;
            }
        }

        private void txtSignUpLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtSignUpFirstName.Text.Length > 0)
            {
                pnlSignUpLastNameUnderline.BackColor = Color.FromArgb(colorCorrectr, colorCorrectg, colorCorrectb);
            } else
            {
                pnlSignUpLastNameUnderline.BackColor = Color.White;
            }
        }

        private void txtSignUpEmail_TextChanged(object sender, EventArgs e)
        {
            if (isValidEmail(sender, e))
            {
                pnlSignUpEmailUnderline.BackColor = Color.FromArgb(colorCorrectr, colorCorrectg, colorCorrectb);
            } else
            {
                pnlSignUpEmailUnderline.BackColor = Color.Coral;
            }
        }
    }
}

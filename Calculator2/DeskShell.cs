using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeskShell {
    
    enum WindowSelector
    {
        Home,
        Calendar,
        Calculator,
        Todo,
        Notepad
    }

    public partial class DeskShell: Form {

        //Import for the Hiding of the caret for the calculator.
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public DeskShell() {
            InitializeComponent();
            
            //Hides the Calculator for now.
            pnlCalcPad.Enabled = true;
            pnlCalcTop.Enabled = true;
            //Central is the parent container
            pnlCentralHolder.Show();
            pnlCentralHolder.Enabled = true;
            pnlLogin.Enabled = false;
            pnlLogin.Hide();
            txtOutput.Hide();
            pnlCalcPad.Hide();
            
        }

        private static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void SetTxtFocused()
        {
            if (!txtOutput.Focused)
            {
                txtOutput.Focus();
                HideCaret(txtOutput.Handle);
            }
        }

        private void KillApplication()
        {
            this.Close();
            Application.Exit();
        }

        #region EventHandlers

        //Information handler for every button.
        private void EvaluaterBtn(object sender, EventArgs e)
        {
            var input = txtOutput.Text.Trim();
            try
            {
                if (input.Equals("ERROR") || input.Equals("0"))
                {
                    txtOutput.Clear();
                }
                txtOutput.Text += ((Button)sender).Text.Trim();
                txtOutput.SelectionStart = txtOutput.Text.Length;
                txtOutput.SelectionLength = 0;
            }
            catch (Exception es)
            {
                Console.WriteLine(es.StackTrace);
            }
            SetTxtFocused();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            txtOutput.Text = "0";
            SetTxtFocused();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = Evaluate(txtOutput.Text.Trim()).ToString();
                //might throw an error.
                txtOutput.SelectionStart = txtOutput.Text.Length;
                txtOutput.SelectionLength = 0;

                //txtOutput.HideSelection = true; //An attempt to fix the problem.
                SetTxtFocused();
            } catch (Exception ex)
            {
                txtOutput.Text = "ERROR";
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            pnlSelectionIdentifier.Height = btnHome.Height;
            pnlSelectionIdentifier.Top = btnHome.Top;

            txtOutput.Hide();
            pnlCalcPad.Hide();
            
            pnlHome.Show();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            pnlSelectionIdentifier.Height = btnCalendar.Height;
            pnlSelectionIdentifier.Top = btnCalendar.Top;

            txtOutput.Hide();
            pnlCalcPad.Hide();

            pnlHome.Hide();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            pnlSelectionIdentifier.Height = btnCalculator.Height;
            pnlSelectionIdentifier.Top = btnCalculator.Top;
            
            pnlHome.Hide();

            //Setting panels to true or false.
            txtOutput.Show();
            pnlCalcPad.Show();

            //Have to set the focus on the text-box
            txtOutput.Focus();
        }

        private void buttonToDo_Click(object sender, EventArgs e)
        {
            pnlSelectionIdentifier.Height = btnToDo.Height;
            pnlSelectionIdentifier.Top = btnToDo.Top;

            txtOutput.Hide();
            pnlCalcPad.Hide();
        }

        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            pnlSelectionIdentifier.Height = btnNotepad.Height;
            pnlSelectionIdentifier.Top = btnNotepad.Top;

            txtOutput.Hide();
            pnlCalcPad.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            KillApplication();
        }
        #endregion

        private void btnLoginScreen_Click(object sender, EventArgs e)
        {
            pnlLogin.Enabled = true;
            pnlLogin.Show();

            pnlAuthentication.BringToFront();
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Enabled = false;
            pnlLogin.Hide();
            pnlAuthentication.SendToBack();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnlLogin.Enabled = false;
            pnlLogin.Hide();

            pnlSignUp.Enabled = true;
            pnlSignUp.Show();
        }

        private void btnBackSignUp_Click(object sender, EventArgs e)
        {
            pnlSignUp.Hide();
            pnlSignUp.Enabled = false;

            pnlLogin.Enabled = true;
            pnlLogin.Show();
        }
    }
}

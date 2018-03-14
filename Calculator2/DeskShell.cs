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
            pnlMain.Enabled = true;
            pnlTop.Enabled = true;

            pnlLogin.Enabled = false;
            pnlLogin.Hide();
            txtOutput.Hide();
            pnlMain.Hide();
            
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
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;

            txtOutput.Hide();
            pnlMain.Hide();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonCalendar.Height;
            panelLeft.Top = buttonCalendar.Top;

            txtOutput.Hide();
            pnlMain.Hide();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonCalculator.Height;
            panelLeft.Top = buttonCalculator.Top;

            //Setting panels to true or false.
            txtOutput.Show();
            pnlMain.Show();

            //Have to set the focus on the text-box
            txtOutput.Focus();
        }

        private void buttonToDo_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonToDo.Height;
            panelLeft.Top = buttonToDo.Top;

            txtOutput.Hide();
            pnlMain.Hide();
        }

        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonNotepad.Height;
            panelLeft.Top = buttonNotepad.Top;

            txtOutput.Hide();
            pnlMain.Hide();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlLogin.Enabled = false;
            pnlLogin.Hide();
        }
    }
}

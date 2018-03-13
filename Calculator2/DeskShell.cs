using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator2 {
    //ALL METHODS ARE PUBLIC FOR UNIT TESTING CURRENTLY!

    
    public partial class DeskShell: Form {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public DeskShell() {
            InitializeComponent();
        }

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
            } catch(Exception es)
            {
                Console.WriteLine(es.StackTrace);
            }
           SetTxtFocused();
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

        #region EventHandlers
        
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
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonCalendar.Height;
            panelLeft.Top = buttonCalendar.Top;
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonCalculator.Height;
            panelLeft.Top = buttonCalculator.Top;
            txtOutput.Focus();
        }

        private void buttonToDo_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonToDo.Height;
            panelLeft.Top = buttonToDo.Top;
        }

        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonNotepad.Height;
            panelLeft.Top = buttonNotepad.Top;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        #endregion
    }
}

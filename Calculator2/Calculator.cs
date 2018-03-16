using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : UserControl
    {


        /*
         *  //Have to set the focus on the text-box
            Calculator2.Calculator.Focus();
         * */

        #region
        //Import for the Hiding of the caret for the calculator.
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        #endregion

        public Calculator()
        {
            InitializeComponent();
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
            } catch (Exception es)
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
        
    }
}

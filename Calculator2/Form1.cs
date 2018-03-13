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

    public partial class Form1 : Form {

        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public Form1() {
            InitializeComponent();
        }

        //Information handler for every button.
        public void EvaluaterBtn(object sender, EventArgs e)
        {
            try
            {
                if (Output.Text.Trim().Equals("ERROR"))
                {
                    Output.Clear();
                }
                Output.Text += ((Button)sender).Text.Trim();
            } catch(Exception es)
            {
                Console.WriteLine(es.StackTrace);
            }
        }

        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        #region EventHandlers

        private void Clear_Click(object sender, EventArgs e)
        {
            Output.Clear();
            Output.Text = "0";
        }

        public void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = Evaluate(Output.Text.Trim()).ToString();
            } catch(Exception ex)
            {
                Output.Text = "ERROR";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

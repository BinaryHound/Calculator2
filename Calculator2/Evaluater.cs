using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Calculator2
{
    public class Evaluater
    {

        public void StringDecoupler(object sender, EventArgs e)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower().Trim().Equals("q"))
                    break;

                try
                {
                    Console.WriteLine(Evaluate(input));
                } catch (Exception ex)
                {
                    Console.WriteLine($"Unable to evaluate. {ex.Message}");
                }
            }
            Console.ReadLine();
        }

        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }



}

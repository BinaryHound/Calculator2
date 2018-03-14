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
        public FormAuthentication()
        {
            InitializeComponent();
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
            DeskShell mainProgram = new DeskShell();
            mainProgram.Show();
        }
    }
}

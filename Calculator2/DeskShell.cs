using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator2;


namespace DeskShell {
    

    public partial class MainApplication: Form {

        //Holds fields, imports, etc.
        #region

        //For updating the UI with time.
        Timer timerNow = new Timer { Interval = 998 };
        
        private const int ButtonSelectionPnlOffset = 36;

        //To have form be drag-able.
        bool TogMove;
        int MValX;
        int MValY;
        #endregion

        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public MainApplication() {
            InitializeComponent();

            //Central is the parent container
            pnlCentralHolder.Show();
            pnlCentralHolder.Enabled = true;
            
        }

        private void KillApplication()
        {
            this.Close();
            Application.Exit();
        }

        #region EventHandlers

        private void buttonHome_Click(object sender, EventArgs e)
        {

            calculator1.Hide();

        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {

            calculator1.Hide();

        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {


            //Instead of doing the above, let's just set the color of the button to be a bit grayer. :)

            calculator1.BringToFront();
            calculator1.Show();
            

        }

        private void buttonToDo_Click(object sender, EventArgs e)
        {

            calculator1.Hide();
        }

        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            calculator1.Hide();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            KillApplication();
        }
        #endregion

        private void btnLoginScreen_Click(object sender, EventArgs e)
        {

        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void btnBackSignUp_Click(object sender, EventArgs e)
        {

        }
        
        //Helper method Region AND Dragability Region.
        #region
        private int HelperSelectionPnlOffset(Button btn)
        {
            return btn.Top + ButtonSelectionPnlOffset;
        }

        private void pnlControlsResize_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pnlControlsResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void pnlControlsResize_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }
        #endregion

        private void timerTickHandler(object sender, EventArgs e)
        {
            lblTimeMainForm.Text = DateTime.Now.ToLongTimeString();
        }
        
        private void MainApplication_Load(object sender, EventArgs e)
        {
            //Make sure to do all of the loading stuff in here.
            calculator1.Hide();

            // To update the first time.
            lblTimeMainForm.Text = DateTime.Now.ToLongTimeString();
            timerNow.Tick += timerTickHandler;
            timerNow.Start();
        }

        private void btnMainFormApplicationProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

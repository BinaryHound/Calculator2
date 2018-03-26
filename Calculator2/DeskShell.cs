using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace DeskShell {


    public partial class MainApplication : Form {

        //Holds fields, imports, etc.
        #region


        //Thread Delegate for the UI.
        private delegate void StringArgReturningVoidDelegate(string text);

        //Thread name.
        private Thread demothread = null;

        //For updating the UI with time.
        //Timer timerNow = new Timer { Interval = 998 };

        private const int ButtonSelectionPnlOffset = 36;

        //To have form be drag-able.
        bool TogMove;
        int MValX;
        int MValY;

        //Welcome Message
        char[] welcomeMessage = { 'W', 'e', 'l', 'c', 'o', 'm', 'e', ',', ' ' };

        #endregion
        

        public string setFirstName { get; set; }
        public string setLastName { get; set; }

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
        
        //Helper method Region AND Dragability Region.
        #region WindowMovement
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
           // timerNow.Tick += timerTickHandler;
            //timerNow.Start();
        }

        private void btnMainFormApplicationProfile_Click(object sender, EventArgs e)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("View Profile", new EventHandler(onContextMenuProfile_Click));
            cm.MenuItems.Add("Add Extensions", new EventHandler(onContextMenuAddExtensions_Click));
            cm.MenuItems.Add("More...", new EventHandler(onContextMenuMore_Click));
            cm.Show(btnMainFormProfile, new Point(0, btnMainFormProfile.Height));
        }

        private void onContextMenuMore_Click(object sender, EventArgs e)
        {
            Console.WriteLine("More button was pressed.");
        }

        private void onContextMenuProfile_Click(object sender, EventArgs e)
        {
            Console.WriteLine("View profile clicked.");
        }

        private void onContextMenuAddExtensions_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add extensions clicked.");
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMoveFeatureOver_Click(object sender, EventArgs e)
        {
            Console.WriteLine("The move feature over was clicked.");
        }

        private void MainApplication_Shown(object sender, EventArgs e)
        {
            //Every tick we want to update the label to make it look like its being typed.
            this.demothread = new Thread(new ThreadStart(this.welcomeThread));
            this.demothread.Start();
        }

        private void welcomeThread()
        {
            StringBuilder welcomeString = new StringBuilder();
            int welcomeStringLength = 0;
            while (welcomeStringLength < welcomeMessage.Length)
            {
                SetText(welcomeString.Append(welcomeMessage[welcomeStringLength]).ToString());
                welcomeStringLength++;
                Thread.Sleep(125);
            }
            
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (this.lblNameHolder.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            } else
            {
                this.lblNameHolder.Text = text;
            }
        }

    }
}

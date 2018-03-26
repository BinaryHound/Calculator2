namespace DeskShell {
    partial class MainApplication {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplication));
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnToDo = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlControlsResize = new System.Windows.Forms.Panel();
            this.lblTimeMainForm = new System.Windows.Forms.Label();
            this.btnMainFormProfile = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlCentralHolder = new System.Windows.Forms.Panel();
            this.calculator1 = new DeskShell.Calculator();
            this.pnlFlowFeaturePicker = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFeatureContainer = new System.Windows.Forms.Panel();
            this.pnlFeatureTop = new System.Windows.Forms.Panel();
            this.btnMoveFeatureOver = new System.Windows.Forms.Button();
            this.lblNameHolder = new System.Windows.Forms.Label();
            this.picLogoMainApp = new System.Windows.Forms.PictureBox();
            this.pnlControlsResize.SuspendLayout();
            this.pnlCentralHolder.SuspendLayout();
            this.pnlFlowFeaturePicker.SuspendLayout();
            this.pnlFeatureContainer.SuspendLayout();
            this.pnlFeatureTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMainApp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNotepad
            // 
            this.btnNotepad.FlatAppearance.BorderSize = 0;
            this.btnNotepad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(176)))), ((int)(((byte)(147)))));
            this.btnNotepad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.btnNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotepad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotepad.ForeColor = System.Drawing.Color.Black;
            this.btnNotepad.Image = ((System.Drawing.Image)(resources.GetObject("btnNotepad.Image")));
            this.btnNotepad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotepad.Location = new System.Drawing.Point(3, 89);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(314, 80);
            this.btnNotepad.TabIndex = 4;
            this.btnNotepad.Text = "Notepad";
            this.btnNotepad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.buttonNotepad_Click);
            // 
            // btnToDo
            // 
            this.btnToDo.FlatAppearance.BorderSize = 0;
            this.btnToDo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(176)))), ((int)(((byte)(147)))));
            this.btnToDo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.btnToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDo.ForeColor = System.Drawing.Color.Black;
            this.btnToDo.Image = ((System.Drawing.Image)(resources.GetObject("btnToDo.Image")));
            this.btnToDo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToDo.Location = new System.Drawing.Point(3, 261);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(314, 80);
            this.btnToDo.TabIndex = 3;
            this.btnToDo.Text = "To Do";
            this.btnToDo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.buttonToDo_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(176)))), ((int)(((byte)(147)))));
            this.btnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.Black;
            this.btnCalculator.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculator.Image")));
            this.btnCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculator.Location = new System.Drawing.Point(3, 175);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(314, 80);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(176)))), ((int)(((byte)(147)))));
            this.btnCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.Black;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.Location = new System.Drawing.Point(3, 347);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(314, 80);
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(176)))), ((int)(((byte)(147)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(314, 80);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(1235, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(45, 47);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlControlsResize
            // 
            this.pnlControlsResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.pnlControlsResize.Controls.Add(this.lblTimeMainForm);
            this.pnlControlsResize.Controls.Add(this.btnMainFormProfile);
            this.pnlControlsResize.Controls.Add(this.buttonExit);
            this.pnlControlsResize.Controls.Add(this.btnMinimize);
            this.pnlControlsResize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlsResize.Location = new System.Drawing.Point(0, 0);
            this.pnlControlsResize.Name = "pnlControlsResize";
            this.pnlControlsResize.Size = new System.Drawing.Size(1280, 47);
            this.pnlControlsResize.TabIndex = 21;
            this.pnlControlsResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControlsResize_MouseDown);
            this.pnlControlsResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlControlsResize_MouseMove);
            this.pnlControlsResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlControlsResize_MouseUp);
            // 
            // lblTimeMainForm
            // 
            this.lblTimeMainForm.AutoSize = true;
            this.lblTimeMainForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeMainForm.Location = new System.Drawing.Point(54, 15);
            this.lblTimeMainForm.Name = "lblTimeMainForm";
            this.lblTimeMainForm.Size = new System.Drawing.Size(0, 20);
            this.lblTimeMainForm.TabIndex = 24;
            // 
            // btnMainFormProfile
            // 
            this.btnMainFormProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnMainFormProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMainFormProfile.FlatAppearance.BorderSize = 0;
            this.btnMainFormProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMainFormProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMainFormProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainFormProfile.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainFormProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMainFormProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnMainFormProfile.Image")));
            this.btnMainFormProfile.Location = new System.Drawing.Point(3, 3);
            this.btnMainFormProfile.Name = "btnMainFormProfile";
            this.btnMainFormProfile.Size = new System.Drawing.Size(45, 41);
            this.btnMainFormProfile.TabIndex = 23;
            this.btnMainFormProfile.UseVisualStyleBackColor = false;
            this.btnMainFormProfile.Click += new System.EventHandler(this.btnMainFormApplicationProfile_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimize.Location = new System.Drawing.Point(1190, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 47);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlCentralHolder
            // 
            this.pnlCentralHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.pnlCentralHolder.Controls.Add(this.calculator1);
            this.pnlCentralHolder.Location = new System.Drawing.Point(323, 47);
            this.pnlCentralHolder.Name = "pnlCentralHolder";
            this.pnlCentralHolder.Size = new System.Drawing.Size(957, 673);
            this.pnlCentralHolder.TabIndex = 15;
            // 
            // calculator1
            // 
            this.calculator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.calculator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculator1.Location = new System.Drawing.Point(0, 0);
            this.calculator1.Name = "calculator1";
            this.calculator1.Size = new System.Drawing.Size(957, 673);
            this.calculator1.TabIndex = 0;
            // 
            // pnlFlowFeaturePicker
            // 
            this.pnlFlowFeaturePicker.AutoScroll = true;
            this.pnlFlowFeaturePicker.Controls.Add(this.btnHome);
            this.pnlFlowFeaturePicker.Controls.Add(this.btnNotepad);
            this.pnlFlowFeaturePicker.Controls.Add(this.btnCalculator);
            this.pnlFlowFeaturePicker.Controls.Add(this.btnToDo);
            this.pnlFlowFeaturePicker.Controls.Add(this.btnCalendar);
            this.pnlFlowFeaturePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFlowFeaturePicker.Location = new System.Drawing.Point(0, 210);
            this.pnlFlowFeaturePicker.Name = "pnlFlowFeaturePicker";
            this.pnlFlowFeaturePicker.Size = new System.Drawing.Size(320, 463);
            this.pnlFlowFeaturePicker.TabIndex = 23;
            // 
            // pnlFeatureContainer
            // 
            this.pnlFeatureContainer.Controls.Add(this.pnlFeatureTop);
            this.pnlFeatureContainer.Controls.Add(this.pnlFlowFeaturePicker);
            this.pnlFeatureContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFeatureContainer.Location = new System.Drawing.Point(0, 47);
            this.pnlFeatureContainer.Name = "pnlFeatureContainer";
            this.pnlFeatureContainer.Size = new System.Drawing.Size(320, 673);
            this.pnlFeatureContainer.TabIndex = 6;
            // 
            // pnlFeatureTop
            // 
            this.pnlFeatureTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.pnlFeatureTop.Controls.Add(this.btnMoveFeatureOver);
            this.pnlFeatureTop.Controls.Add(this.lblNameHolder);
            this.pnlFeatureTop.Controls.Add(this.picLogoMainApp);
            this.pnlFeatureTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFeatureTop.Location = new System.Drawing.Point(0, 0);
            this.pnlFeatureTop.Name = "pnlFeatureTop";
            this.pnlFeatureTop.Size = new System.Drawing.Size(320, 213);
            this.pnlFeatureTop.TabIndex = 24;
            // 
            // btnMoveFeatureOver
            // 
            this.btnMoveFeatureOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnMoveFeatureOver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoveFeatureOver.FlatAppearance.BorderSize = 0;
            this.btnMoveFeatureOver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMoveFeatureOver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMoveFeatureOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveFeatureOver.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFeatureOver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMoveFeatureOver.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveFeatureOver.Image")));
            this.btnMoveFeatureOver.Location = new System.Drawing.Point(3, 6);
            this.btnMoveFeatureOver.Name = "btnMoveFeatureOver";
            this.btnMoveFeatureOver.Size = new System.Drawing.Size(45, 41);
            this.btnMoveFeatureOver.TabIndex = 25;
            this.btnMoveFeatureOver.UseVisualStyleBackColor = false;
            this.btnMoveFeatureOver.Click += new System.EventHandler(this.btnMoveFeatureOver_Click);
            // 
            // lblNameHolder
            // 
            this.lblNameHolder.AutoSize = true;
            this.lblNameHolder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHolder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameHolder.Location = new System.Drawing.Point(70, 148);
            this.lblNameHolder.Name = "lblNameHolder";
            this.lblNameHolder.Size = new System.Drawing.Size(0, 24);
            this.lblNameHolder.TabIndex = 1;
            // 
            // picLogoMainApp
            // 
            this.picLogoMainApp.Image = ((System.Drawing.Image)(resources.GetObject("picLogoMainApp.Image")));
            this.picLogoMainApp.Location = new System.Drawing.Point(89, 6);
            this.picLogoMainApp.Name = "picLogoMainApp";
            this.picLogoMainApp.Size = new System.Drawing.Size(130, 119);
            this.picLogoMainApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoMainApp.TabIndex = 0;
            this.picLogoMainApp.TabStop = false;
            // 
            // MainApplication
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlFeatureContainer);
            this.Controls.Add(this.pnlControlsResize);
            this.Controls.Add(this.pnlCentralHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainApplication_Load);
            this.Shown += new System.EventHandler(this.MainApplication_Shown);
            this.pnlControlsResize.ResumeLayout(false);
            this.pnlControlsResize.PerformLayout();
            this.pnlCentralHolder.ResumeLayout(false);
            this.pnlFlowFeaturePicker.ResumeLayout(false);
            this.pnlFeatureContainer.ResumeLayout(false);
            this.pnlFeatureTop.ResumeLayout(false);
            this.pnlFeatureTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMainApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlControlsResize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlCentralHolder;
        private System.Windows.Forms.FlowLayoutPanel pnlFlowFeaturePicker;
        private System.Windows.Forms.Label lblTimeMainForm;
        private System.Windows.Forms.Button btnMainFormProfile;
        private DeskShell.Calculator calculator1;
        private System.Windows.Forms.Panel pnlFeatureContainer;
        private System.Windows.Forms.Panel pnlFeatureTop;
        private System.Windows.Forms.Label lblNameHolder;
        private System.Windows.Forms.PictureBox picLogoMainApp;
        private System.Windows.Forms.Button btnMoveFeatureOver;
    }
}


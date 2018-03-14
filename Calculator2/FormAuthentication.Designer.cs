namespace DeskShell
{
    partial class FormAuthentication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthentication));
            this.pnlControlsResize = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlLoginLeftSide = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblSignUpSlogan = new System.Windows.Forms.Label();
            this.lblSignUpHook = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.pnlUnderlinePassword = new System.Windows.Forms.Panel();
            this.pnlUnderlineUser = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picLoginPassword = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.picLoginUser = new System.Windows.Forms.PictureBox();
            this.picLogoLogin = new System.Windows.Forms.PictureBox();
            this.picLoginGif = new System.Windows.Forms.PictureBox();
            this.pnlControlsResize.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlLoginLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlsResize
            // 
            this.pnlControlsResize.BackColor = System.Drawing.Color.Transparent;
            this.pnlControlsResize.Controls.Add(this.buttonExit);
            this.pnlControlsResize.Controls.Add(this.btnMinimize);
            this.pnlControlsResize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlsResize.Location = new System.Drawing.Point(0, 0);
            this.pnlControlsResize.Name = "pnlControlsResize";
            this.pnlControlsResize.Size = new System.Drawing.Size(1280, 36);
            this.pnlControlsResize.TabIndex = 22;
            this.pnlControlsResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControlsResize_MouseDown);
            this.pnlControlsResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlControlsResize_MouseMove);
            this.pnlControlsResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlControlsResize_MouseUp);
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
            this.buttonExit.Location = new System.Drawing.Point(1245, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(35, 36);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(1204, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 36);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.pnlLoginLeftSide);
            this.pnlLogin.Controls.Add(this.picLoginGif);
            this.pnlLogin.Location = new System.Drawing.Point(0, 35);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1280, 687);
            this.pnlLogin.TabIndex = 23;
            // 
            // pnlLoginLeftSide
            // 
            this.pnlLoginLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.pnlLoginLeftSide.Controls.Add(this.btnSignUp);
            this.pnlLoginLeftSide.Controls.Add(this.lblSignUpSlogan);
            this.pnlLoginLeftSide.Controls.Add(this.lblSignUpHook);
            this.pnlLoginLeftSide.Controls.Add(this.btnLogin);
            this.pnlLoginLeftSide.Controls.Add(this.chkBoxRememberMe);
            this.pnlLoginLeftSide.Controls.Add(this.lblHaveAccount);
            this.pnlLoginLeftSide.Controls.Add(this.pnlUnderlinePassword);
            this.pnlLoginLeftSide.Controls.Add(this.pnlUnderlineUser);
            this.pnlLoginLeftSide.Controls.Add(this.txtPassword);
            this.pnlLoginLeftSide.Controls.Add(this.picLoginPassword);
            this.pnlLoginLeftSide.Controls.Add(this.txtLogin);
            this.pnlLoginLeftSide.Controls.Add(this.picLoginUser);
            this.pnlLoginLeftSide.Controls.Add(this.picLogoLogin);
            this.pnlLoginLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginLeftSide.Name = "pnlLoginLeftSide";
            this.pnlLoginLeftSide.Size = new System.Drawing.Size(573, 685);
            this.pnlLoginLeftSide.TabIndex = 1;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnSignUp.Location = new System.Drawing.Point(54, 547);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(424, 42);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // lblSignUpSlogan
            // 
            this.lblSignUpSlogan.AutoSize = true;
            this.lblSignUpSlogan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSignUpSlogan.Location = new System.Drawing.Point(51, 517);
            this.lblSignUpSlogan.Name = "lblSignUpSlogan";
            this.lblSignUpSlogan.Size = new System.Drawing.Size(204, 16);
            this.lblSignUpSlogan.TabIndex = 13;
            this.lblSignUpSlogan.Text = "SIGN UP NOW TO JOIN OUR FAMILY.";
            // 
            // lblSignUpHook
            // 
            this.lblSignUpHook.AutoSize = true;
            this.lblSignUpHook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpHook.ForeColor = System.Drawing.Color.White;
            this.lblSignUpHook.Location = new System.Drawing.Point(50, 486);
            this.lblSignUpHook.Name = "lblSignUpHook";
            this.lblSignUpHook.Size = new System.Drawing.Size(143, 19);
            this.lblSignUpHook.TabIndex = 12;
            this.lblSignUpHook.Text = "NEW TO TECHJOI?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(54, 424);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(424, 42);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkBoxRememberMe
            // 
            this.chkBoxRememberMe.AutoSize = true;
            this.chkBoxRememberMe.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkBoxRememberMe.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.chkBoxRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBoxRememberMe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxRememberMe.ForeColor = System.Drawing.Color.White;
            this.chkBoxRememberMe.Location = new System.Drawing.Point(54, 394);
            this.chkBoxRememberMe.Name = "chkBoxRememberMe";
            this.chkBoxRememberMe.Size = new System.Drawing.Size(132, 24);
            this.chkBoxRememberMe.TabIndex = 10;
            this.chkBoxRememberMe.Text = "Remember me";
            this.chkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.AutoSize = true;
            this.lblHaveAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaveAccount.ForeColor = System.Drawing.Color.White;
            this.lblHaveAccount.Location = new System.Drawing.Point(50, 190);
            this.lblHaveAccount.Name = "lblHaveAccount";
            this.lblHaveAccount.Size = new System.Drawing.Size(259, 21);
            this.lblHaveAccount.TabIndex = 0;
            this.lblHaveAccount.Text = "ALREADY HAVE AN ACCOUNT?";
            // 
            // pnlUnderlinePassword
            // 
            this.pnlUnderlinePassword.BackColor = System.Drawing.Color.White;
            this.pnlUnderlinePassword.Location = new System.Drawing.Point(54, 372);
            this.pnlUnderlinePassword.Name = "pnlUnderlinePassword";
            this.pnlUnderlinePassword.Size = new System.Drawing.Size(423, 2);
            this.pnlUnderlinePassword.TabIndex = 9;
            // 
            // pnlUnderlineUser
            // 
            this.pnlUnderlineUser.BackColor = System.Drawing.Color.White;
            this.pnlUnderlineUser.Location = new System.Drawing.Point(54, 278);
            this.pnlUnderlineUser.Name = "pnlUnderlineUser";
            this.pnlUnderlineUser.Size = new System.Drawing.Size(423, 2);
            this.pnlUnderlineUser.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(87, 336);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(391, 30);
            this.txtPassword.TabIndex = 7;
            // 
            // picLoginPassword
            // 
            this.picLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.picLoginPassword.Image = ((System.Drawing.Image)(resources.GetObject("picLoginPassword.Image")));
            this.picLoginPassword.Location = new System.Drawing.Point(54, 336);
            this.picLoginPassword.Name = "picLoginPassword";
            this.picLoginPassword.Size = new System.Drawing.Size(33, 30);
            this.picLoginPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginPassword.TabIndex = 6;
            this.picLoginPassword.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(87, 242);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(391, 30);
            this.txtLogin.TabIndex = 3;
            // 
            // picLoginUser
            // 
            this.picLoginUser.BackColor = System.Drawing.Color.Transparent;
            this.picLoginUser.Image = ((System.Drawing.Image)(resources.GetObject("picLoginUser.Image")));
            this.picLoginUser.Location = new System.Drawing.Point(54, 242);
            this.picLoginUser.Name = "picLoginUser";
            this.picLoginUser.Size = new System.Drawing.Size(33, 30);
            this.picLoginUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginUser.TabIndex = 2;
            this.picLoginUser.TabStop = false;
            // 
            // picLogoLogin
            // 
            this.picLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogoLogin.Image")));
            this.picLogoLogin.Location = new System.Drawing.Point(179, 7);
            this.picLogoLogin.Name = "picLogoLogin";
            this.picLogoLogin.Size = new System.Drawing.Size(182, 154);
            this.picLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoLogin.TabIndex = 0;
            this.picLogoLogin.TabStop = false;
            // 
            // picLoginGif
            // 
            this.picLoginGif.Image = ((System.Drawing.Image)(resources.GetObject("picLoginGif.Image")));
            this.picLoginGif.Location = new System.Drawing.Point(571, 0);
            this.picLoginGif.Name = "picLoginGif";
            this.picLoginGif.Size = new System.Drawing.Size(709, 686);
            this.picLoginGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoginGif.TabIndex = 0;
            this.picLoginGif.TabStop = false;
            // 
            // FormAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlControlsResize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuthentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlControlsResize.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLoginLeftSide.ResumeLayout(false);
            this.pnlLoginLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControlsResize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox picLoginGif;
        private System.Windows.Forms.Panel pnlLoginLeftSide;
        private System.Windows.Forms.CheckBox chkBoxRememberMe;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.Panel pnlUnderlinePassword;
        private System.Windows.Forms.Panel pnlUnderlineUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picLoginPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox picLoginUser;
        private System.Windows.Forms.PictureBox picLogoLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblSignUpSlogan;
        private System.Windows.Forms.Label lblSignUpHook;
        private System.Windows.Forms.Button btnLogin;
    }
}
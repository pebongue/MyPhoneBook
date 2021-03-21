namespace MyPhoneBook.PL.Forms
{
    partial class fviewConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fviewConnect));
            this.picboxConnect = new System.Windows.Forms.PictureBox();
            this.linklblLoginForgotPwd = new System.Windows.Forms.LinkLabel();
            this.txtLoginPassword = new DevExpress.XtraEditors.TextEdit();
            this.chkboxLoginRememberMe = new DevExpress.XtraEditors.CheckEdit();
            this.btnLoginConnect = new DevExpress.XtraEditors.SimpleButton();
            this.cbLoginUsername = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblLoginContactAdmin = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picboxConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxLoginRememberMe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoginUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxConnect
            // 
            this.picboxConnect.BackColor = System.Drawing.SystemColors.Control;
            this.picboxConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxConnect.Image = global::MyPhoneBook.PL.Properties.Resources.mobileme_login;
            this.picboxConnect.Location = new System.Drawing.Point(0, 0);
            this.picboxConnect.Name = "picboxConnect";
            this.picboxConnect.Size = new System.Drawing.Size(610, 344);
            this.picboxConnect.TabIndex = 0;
            this.picboxConnect.TabStop = false;
            this.picboxConnect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picboxConnect_MouseMove);
            this.picboxConnect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picboxConnect_MouseDown);
            this.picboxConnect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picboxConnect_MouseUp);
            // 
            // linklblLoginForgotPwd
            // 
            this.linklblLoginForgotPwd.Location = new System.Drawing.Point(189, 205);
            this.linklblLoginForgotPwd.Name = "linklblLoginForgotPwd";
            this.linklblLoginForgotPwd.Size = new System.Drawing.Size(111, 23);
            this.linklblLoginForgotPwd.TabIndex = 3;
            this.linklblLoginForgotPwd.TabStop = true;
            this.linklblLoginForgotPwd.Text = "Forgot Password?";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(192, 131);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtLoginPassword.Properties.UseSystemPasswordChar = true;
            this.txtLoginPassword.Properties.ValidateOnEnterKey = true;
            this.txtLoginPassword.Size = new System.Drawing.Size(227, 20);
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPwdKeyPress);
            // 
            // chkboxLoginRememberMe
            // 
            this.chkboxLoginRememberMe.Location = new System.Drawing.Point(190, 167);
            this.chkboxLoginRememberMe.Name = "chkboxLoginRememberMe";
            this.chkboxLoginRememberMe.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkboxLoginRememberMe.Properties.Appearance.Options.UseBackColor = true;
            this.chkboxLoginRememberMe.Properties.Caption = "Remember me";
            this.chkboxLoginRememberMe.Size = new System.Drawing.Size(229, 19);
            this.chkboxLoginRememberMe.TabIndex = 2;
            // 
            // btnLoginConnect
            // 
            this.btnLoginConnect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoginConnect.Location = new System.Drawing.Point(331, 200);
            this.btnLoginConnect.Name = "btnLoginConnect";
            this.btnLoginConnect.Size = new System.Drawing.Size(88, 23);
            this.btnLoginConnect.TabIndex = 4;
            this.btnLoginConnect.Text = "&Connect";
            this.btnLoginConnect.Click += new System.EventHandler(this.OnLoginConnectClick);
            // 
            // cbLoginUsername
            // 
            this.cbLoginUsername.Location = new System.Drawing.Point(192, 97);
            this.cbLoginUsername.Name = "cbLoginUsername";
            this.cbLoginUsername.Properties.AutoHeight = false;
            this.cbLoginUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cbLoginUsername.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLoginUsername.Properties.Items.AddRange(new object[] {
            "Admin"});
            this.cbLoginUsername.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbLoginUsername.Size = new System.Drawing.Size(227, 20);
            this.cbLoginUsername.TabIndex = 0;
            // 
            // lblLoginContactAdmin
            // 
            this.lblLoginContactAdmin.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblLoginContactAdmin.Location = new System.Drawing.Point(194, 273);
            this.lblLoginContactAdmin.Name = "lblLoginContactAdmin";
            this.lblLoginContactAdmin.Size = new System.Drawing.Size(236, 13);
            this.lblLoginContactAdmin.TabIndex = 5;
            this.lblLoginContactAdmin.Text = "Please contact your administrator to gain access.";
            // 
            // fviewConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(610, 344);
            this.Controls.Add(this.lblLoginContactAdmin);
            this.Controls.Add(this.cbLoginUsername);
            this.Controls.Add(this.btnLoginConnect);
            this.Controls.Add(this.chkboxLoginRememberMe);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.linklblLoginForgotPwd);
            this.Controls.Add(this.picboxConnect);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fviewConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My PhoneBook - connect to address book";
            ((System.ComponentModel.ISupportInitialize)(this.picboxConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxLoginRememberMe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoginUsername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxConnect;
        private System.Windows.Forms.LinkLabel linklblLoginForgotPwd;
        private DevExpress.XtraEditors.TextEdit txtLoginPassword;
        private DevExpress.XtraEditors.CheckEdit chkboxLoginRememberMe;
        private DevExpress.XtraEditors.SimpleButton btnLoginConnect;
        private DevExpress.XtraEditors.ComboBoxEdit cbLoginUsername;
        private DevExpress.XtraEditors.LabelControl lblLoginContactAdmin;
    }
}
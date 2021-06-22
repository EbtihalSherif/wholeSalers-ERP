namespace wholesaler_ERP
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.txtbox_userName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_userName
            // 
            this.txtbox_userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_userName.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_userName.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_userName.HintText = "";
            this.txtbox_userName.isPassword = false;
            this.txtbox_userName.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbox_userName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txtbox_userName.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbox_userName.LineThickness = 3;
            this.txtbox_userName.Location = new System.Drawing.Point(77, 273);
            this.txtbox_userName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbox_userName.Name = "txtbox_userName";
            this.txtbox_userName.Size = new System.Drawing.Size(355, 42);
            this.txtbox_userName.TabIndex = 1;
            this.txtbox_userName.Text = "اسم المستخدم";
            this.txtbox_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbox_userName.OnValueChanged += new System.EventHandler(this.txtbox_userName_OnValueChanged);
            this.txtbox_userName.Click += new System.EventHandler(this.txtbox_userName_Click);
            this.txtbox_userName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbox_userName_MouseClick);
            this.txtbox_userName.MouseEnter += new System.EventHandler(this.txtbox_userName_MouseEnter);
            this.txtbox_userName.MouseLeave += new System.EventHandler(this.txtbox_userName_MouseLeave);
            this.txtbox_userName.MouseHover += new System.EventHandler(this.txtbox_userName_MouseHover_1);
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Neo Sans Arabic", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_password.HintText = "";
            this.txt_password.isPassword = true;
            this.txt_password.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.txt_password.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_password.LineThickness = 3;
            this.txt_password.Location = new System.Drawing.Point(77, 345);
            this.txt_password.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(363, 41);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "كلمه المرور";
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_password.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            this.txt_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuMaterialTextbox2_MouseClick);
            this.txt_password.MouseEnter += new System.EventHandler(this.txt_password_MouseEnter);
            this.txt_password.MouseLeave += new System.EventHandler(this.txt_password_MouseLeave);
            this.txt_password.MouseHover += new System.EventHandler(this.txtbox_userName_MouseHover_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::wholesaler_ERP.Properties.Resources.login__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(140, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 208);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 20;
            this.btn_login.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.btn_login.ActiveForecolor = System.Drawing.Color.Snow;
            this.btn_login.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "تسجيل دخول";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Neo Sans Arabic", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btn_login.IdleForecolor = System.Drawing.Color.White;
            this.btn_login.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(140, 473);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(200, 46);
            this.btn_login.TabIndex = 6;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txtbox_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل دخول";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_userName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_password;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace View
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Warning = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.linkLabel_Forgot = new System.Windows.Forms.LinkLabel();
            this.checkBox_Remember = new System.Windows.Forms.CheckBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.label_register = new System.Windows.Forms.LinkLabel();
            this.panel_forgot = new System.Windows.Forms.Panel();
            this.button_hide = new System.Windows.Forms.Button();
            this.button_RequestPass = new System.Windows.Forms.Button();
            this.textBox_ForgotEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ForgotHeader = new System.Windows.Forms.Label();
            this.panel_forgot.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Please provide login credentials to login to\r\nNoDesk for The Garden Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // label_Warning
            // 
            this.label_Warning.AutoSize = true;
            this.label_Warning.ForeColor = System.Drawing.Color.Red;
            this.label_Warning.Location = new System.Drawing.Point(295, 374);
            this.label_Warning.Name = "label_Warning";
            this.label_Warning.Size = new System.Drawing.Size(211, 15);
            this.label_Warning.TabIndex = 20;
            this.label_Warning.Text = "                                                                    \r\n";
            this.label_Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Warning.UseWaitCursor = true;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(316, 314);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(152, 41);
            this.button_Login.TabIndex = 19;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.UseWaitCursor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click_1);
            // 
            // linkLabel_Forgot
            // 
            this.linkLabel_Forgot.AutoSize = true;
            this.linkLabel_Forgot.Location = new System.Drawing.Point(464, 279);
            this.linkLabel_Forgot.Name = "linkLabel_Forgot";
            this.linkLabel_Forgot.Size = new System.Drawing.Size(124, 15);
            this.linkLabel_Forgot.TabIndex = 18;
            this.linkLabel_Forgot.TabStop = true;
            this.linkLabel_Forgot.Text = "Forgot Login Details?";
            this.linkLabel_Forgot.UseWaitCursor = true;
            this.linkLabel_Forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Forgot_LinkClicked_1);
            // 
            // checkBox_Remember
            // 
            this.checkBox_Remember.AutoSize = true;
            this.checkBox_Remember.Location = new System.Drawing.Point(219, 279);
            this.checkBox_Remember.Name = "checkBox_Remember";
            this.checkBox_Remember.Size = new System.Drawing.Size(110, 19);
            this.checkBox_Remember.TabIndex = 17;
            this.checkBox_Remember.Text = "Remember Me";
            this.checkBox_Remember.UseVisualStyleBackColor = true;
            this.checkBox_Remember.UseWaitCursor = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(216, 237);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(78, 20);
            this.label_Password.TabIndex = 16;
            this.label_Password.Text = "Password";
            this.label_Password.UseWaitCursor = true;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(215, 169);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(83, 20);
            this.label_Username.TabIndex = 15;
            this.label_Username.Text = "Username";
            this.label_Username.UseWaitCursor = true;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Location = new System.Drawing.Point(219, 260);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(368, 13);
            this.textBox_Password.TabIndex = 14;
            this.textBox_Password.UseWaitCursor = true;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Username.Location = new System.Drawing.Point(220, 192);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(368, 13);
            this.textBox_Username.TabIndex = 13;
            this.textBox_Username.UseWaitCursor = true;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(298, 63);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(170, 29);
            this.label_login.TabIndex = 12;
            this.label_login.Text = "NoDesk: TGG";
            this.label_login.UseWaitCursor = true;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Red;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_close.Location = new System.Drawing.Point(728, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(60, 57);
            this.button_close.TabIndex = 22;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_register
            // 
            this.label_register.Location = new System.Drawing.Point(0, 0);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(100, 23);
            this.label_register.TabIndex = 0;
            // 
            // panel_forgot
            // 
            this.panel_forgot.Controls.Add(this.button_hide);
            this.panel_forgot.Controls.Add(this.button_RequestPass);
            this.panel_forgot.Controls.Add(this.textBox_ForgotEmail);
            this.panel_forgot.Controls.Add(this.label2);
            this.panel_forgot.Controls.Add(this.label_ForgotHeader);
            this.panel_forgot.Location = new System.Drawing.Point(175, 95);
            this.panel_forgot.Name = "panel_forgot";
            this.panel_forgot.Size = new System.Drawing.Size(428, 263);
            this.panel_forgot.TabIndex = 23;
            this.panel_forgot.Visible = false;
            // 
            // button_hide
            // 
            this.button_hide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_hide.Location = new System.Drawing.Point(90, 145);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(31, 25);
            this.button_hide.TabIndex = 9;
            this.button_hide.Text = "<";
            this.button_hide.UseVisualStyleBackColor = false;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            // 
            // button_RequestPass
            // 
            this.button_RequestPass.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_RequestPass.Location = new System.Drawing.Point(140, 145);
            this.button_RequestPass.Name = "button_RequestPass";
            this.button_RequestPass.Size = new System.Drawing.Size(134, 25);
            this.button_RequestPass.TabIndex = 8;
            this.button_RequestPass.Text = "Request Password";
            this.button_RequestPass.UseVisualStyleBackColor = false;
            this.button_RequestPass.Click += new System.EventHandler(this.button_RequestPass_Click);
            // 
            // textBox_ForgotEmail
            // 
            this.textBox_ForgotEmail.Location = new System.Drawing.Point(90, 100);
            this.textBox_ForgotEmail.Name = "textBox_ForgotEmail";
            this.textBox_ForgotEmail.Size = new System.Drawing.Size(241, 20);
            this.textBox_ForgotEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please enter your account\'s email address in order to\r\nrequest a new password.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ForgotHeader
            // 
            this.label_ForgotHeader.AutoSize = true;
            this.label_ForgotHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ForgotHeader.Location = new System.Drawing.Point(122, 0);
            this.label_ForgotHeader.Name = "label_ForgotHeader";
            this.label_ForgotHeader.Size = new System.Drawing.Size(174, 25);
            this.label_ForgotHeader.TabIndex = 5;
            this.label_ForgotHeader.Text = "Forgot Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_forgot);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Warning);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.linkLabel_Forgot);
            this.Controls.Add(this.checkBox_Remember);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel_forgot.ResumeLayout(false);
            this.panel_forgot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Warning;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.LinkLabel linkLabel_Forgot;
        private System.Windows.Forms.CheckBox checkBox_Remember;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.LinkLabel label_register;
        private System.Windows.Forms.Panel panel_forgot;
        private System.Windows.Forms.Button button_RequestPass;
        private System.Windows.Forms.TextBox textBox_ForgotEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ForgotHeader;
        private System.Windows.Forms.Button button_hide;
    }
}
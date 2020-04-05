namespace View
{
    partial class ForgotLogin
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
            this.label_ForgotHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ForgotEmail = new System.Windows.Forms.TextBox();
            this.button_RequestPass = new System.Windows.Forms.Button();
            this.label_ForgotWarning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ForgotHeader
            // 
            this.label_ForgotHeader.AutoSize = true;
            this.label_ForgotHeader.Location = new System.Drawing.Point(335, 105);
            this.label_ForgotHeader.Name = "label_ForgotHeader";
            this.label_ForgotHeader.Size = new System.Drawing.Size(99, 15);
            this.label_ForgotHeader.TabIndex = 0;
            this.label_ForgotHeader.Text = "Forgot Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter your account\'s email address in order to\r\nrequest a new password.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ForgotEmail
            // 
            this.textBox_ForgotEmail.Location = new System.Drawing.Point(287, 189);
            this.textBox_ForgotEmail.Name = "textBox_ForgotEmail";
            this.textBox_ForgotEmail.Size = new System.Drawing.Size(198, 20);
            this.textBox_ForgotEmail.TabIndex = 2;
            // 
            // button_RequestPass
            // 
            this.button_RequestPass.Location = new System.Drawing.Point(320, 237);
            this.button_RequestPass.Name = "button_RequestPass";
            this.button_RequestPass.Size = new System.Drawing.Size(134, 23);
            this.button_RequestPass.TabIndex = 3;
            this.button_RequestPass.Text = "Request Password";
            this.button_RequestPass.UseVisualStyleBackColor = true;
            this.button_RequestPass.Click += new System.EventHandler(this.button_RequestPass_Click);
            // 
            // label_ForgotWarning
            // 
            this.label_ForgotWarning.AutoSize = true;
            this.label_ForgotWarning.ForeColor = System.Drawing.Color.Red;
            this.label_ForgotWarning.Location = new System.Drawing.Point(335, 281);
            this.label_ForgotWarning.Name = "label_ForgotWarning";
            this.label_ForgotWarning.Size = new System.Drawing.Size(0, 15);
            this.label_ForgotWarning.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_ForgotWarning);
            this.Controls.Add(this.button_RequestPass);
            this.Controls.Add(this.textBox_ForgotEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ForgotHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotLogin";
            this.Text = "ForgotLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ForgotHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ForgotEmail;
        private System.Windows.Forms.Button button_RequestPass;
        private System.Windows.Forms.Label label_ForgotWarning;
        private System.Windows.Forms.Button button1;
    }
}
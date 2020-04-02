namespace View
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_userManagement = new System.Windows.Forms.Panel();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.filter_txt = new System.Windows.Forms.TextBox();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.userManagement_lbl = new System.Windows.Forms.Label();
            this.panel_addUser = new System.Windows.Forms.Panel();
            this.UMError_lbl = new System.Windows.Forms.Label();
            this.confirmAddUser_btn = new System.Windows.Forms.Button();
            this.cancelAddUser_btn = new System.Windows.Forms.Button();
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.comboBox_userType = new System.Windows.Forms.ComboBox();
            this.checkBox_sendPW = new System.Windows.Forms.CheckBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.firstName_txt = new System.Windows.Forms.TextBox();
            this.sendPW_lbl = new System.Windows.Forms.Label();
            this.location_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.userType_lbl = new System.Windows.Forms.Label();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.firstName_lbl = new System.Windows.Forms.Label();
            this.CreateUser_lbl = new System.Windows.Forms.Label();
            this.menuDashboard_btn = new System.Windows.Forms.Button();
            this.menuIncident_btn = new System.Windows.Forms.Button();
            this.menuUser_btn = new System.Windows.Forms.Button();
            this.licensed_lbl = new System.Windows.Forms.Label();
            this.NoDesk_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_userManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.panel_addUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_userManagement
            // 
            this.panel_userManagement.Controls.Add(this.addUser_btn);
            this.panel_userManagement.Controls.Add(this.filter_txt);
            this.panel_userManagement.Controls.Add(this.dataGridView_users);
            this.panel_userManagement.Controls.Add(this.userManagement_lbl);
            this.panel_userManagement.Location = new System.Drawing.Point(1, 61);
            this.panel_userManagement.Name = "panel_userManagement";
            this.panel_userManagement.Size = new System.Drawing.Size(799, 390);
            this.panel_userManagement.TabIndex = 0;
            // 
            // addUser_btn
            // 
            this.addUser_btn.BackColor = System.Drawing.Color.Chartreuse;
            this.addUser_btn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.addUser_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addUser_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser_btn.Location = new System.Drawing.Point(567, 42);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(174, 31);
            this.addUser_btn.TabIndex = 3;
            this.addUser_btn.Text = "+ ADD NEW USER";
            this.addUser_btn.UseVisualStyleBackColor = false;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // filter_txt
            // 
            this.filter_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_txt.Location = new System.Drawing.Point(51, 47);
            this.filter_txt.Name = "filter_txt";
            this.filter_txt.Size = new System.Drawing.Size(239, 22);
            this.filter_txt.TabIndex = 2;
            this.filter_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filter_txt_KeyPress);
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.AllowUserToAddRows = false;
            this.dataGridView_users.AllowUserToDeleteRows = false;
            this.dataGridView_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_users.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_users.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_users.Location = new System.Drawing.Point(51, 81);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.ReadOnly = true;
            this.dataGridView_users.Size = new System.Drawing.Size(697, 309);
            this.dataGridView_users.TabIndex = 1;
            // 
            // userManagement_lbl
            // 
            this.userManagement_lbl.AutoSize = true;
            this.userManagement_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagement_lbl.Location = new System.Drawing.Point(46, 9);
            this.userManagement_lbl.Name = "userManagement_lbl";
            this.userManagement_lbl.Size = new System.Drawing.Size(203, 25);
            this.userManagement_lbl.TabIndex = 0;
            this.userManagement_lbl.Text = "User Management";
            // 
            // panel_addUser
            // 
            this.panel_addUser.Controls.Add(this.UMError_lbl);
            this.panel_addUser.Controls.Add(this.confirmAddUser_btn);
            this.panel_addUser.Controls.Add(this.cancelAddUser_btn);
            this.panel_addUser.Controls.Add(this.comboBox_location);
            this.panel_addUser.Controls.Add(this.comboBox_userType);
            this.panel_addUser.Controls.Add(this.checkBox_sendPW);
            this.panel_addUser.Controls.Add(this.email_txt);
            this.panel_addUser.Controls.Add(this.phone_txt);
            this.panel_addUser.Controls.Add(this.lastName_txt);
            this.panel_addUser.Controls.Add(this.firstName_txt);
            this.panel_addUser.Controls.Add(this.sendPW_lbl);
            this.panel_addUser.Controls.Add(this.location_lbl);
            this.panel_addUser.Controls.Add(this.phone_lbl);
            this.panel_addUser.Controls.Add(this.email_lbl);
            this.panel_addUser.Controls.Add(this.userType_lbl);
            this.panel_addUser.Controls.Add(this.lastName_lbl);
            this.panel_addUser.Controls.Add(this.firstName_lbl);
            this.panel_addUser.Controls.Add(this.CreateUser_lbl);
            this.panel_addUser.Location = new System.Drawing.Point(1, 74);
            this.panel_addUser.Name = "panel_addUser";
            this.panel_addUser.Size = new System.Drawing.Size(799, 380);
            this.panel_addUser.TabIndex = 4;
            // 
            // UMError_lbl
            // 
            this.UMError_lbl.AutoSize = true;
            this.UMError_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UMError_lbl.ForeColor = System.Drawing.Color.Red;
            this.UMError_lbl.Location = new System.Drawing.Point(222, 26);
            this.UMError_lbl.Name = "UMError_lbl";
            this.UMError_lbl.Size = new System.Drawing.Size(0, 24);
            this.UMError_lbl.TabIndex = 17;
            // 
            // confirmAddUser_btn
            // 
            this.confirmAddUser_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.confirmAddUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmAddUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmAddUser_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.confirmAddUser_btn.Location = new System.Drawing.Point(331, 309);
            this.confirmAddUser_btn.Name = "confirmAddUser_btn";
            this.confirmAddUser_btn.Size = new System.Drawing.Size(106, 36);
            this.confirmAddUser_btn.TabIndex = 16;
            this.confirmAddUser_btn.Text = "ADD USER";
            this.confirmAddUser_btn.UseVisualStyleBackColor = false;
            this.confirmAddUser_btn.Click += new System.EventHandler(this.confirmAddUser_btn_Click);
            // 
            // cancelAddUser_btn
            // 
            this.cancelAddUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelAddUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddUser_btn.Location = new System.Drawing.Point(226, 309);
            this.cancelAddUser_btn.Name = "cancelAddUser_btn";
            this.cancelAddUser_btn.Size = new System.Drawing.Size(99, 36);
            this.cancelAddUser_btn.TabIndex = 15;
            this.cancelAddUser_btn.Text = "CANCEL";
            this.cancelAddUser_btn.UseVisualStyleBackColor = true;
            this.cancelAddUser_btn.Click += new System.EventHandler(this.cancelAddUser_btn_Click);
            // 
            // comboBox_location
            // 
            this.comboBox_location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Knuppeldam",
            "Headquarters (HQ)"});
            this.comboBox_location.Location = new System.Drawing.Point(212, 241);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(240, 21);
            this.comboBox_location.TabIndex = 14;
            // 
            // comboBox_userType
            // 
            this.comboBox_userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_userType.FormattingEnabled = true;
            this.comboBox_userType.Items.AddRange(new object[] {
            "Employee",
            "Service desk employee"});
            this.comboBox_userType.Location = new System.Drawing.Point(212, 139);
            this.comboBox_userType.Name = "comboBox_userType";
            this.comboBox_userType.Size = new System.Drawing.Size(240, 21);
            this.comboBox_userType.TabIndex = 13;
            this.comboBox_userType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox_sendPW
            // 
            this.checkBox_sendPW.AutoSize = true;
            this.checkBox_sendPW.Location = new System.Drawing.Point(212, 276);
            this.checkBox_sendPW.Name = "checkBox_sendPW";
            this.checkBox_sendPW.Size = new System.Drawing.Size(240, 17);
            this.checkBox_sendPW.TabIndex = 12;
            this.checkBox_sendPW.Text = "yes, a password e-mail will be sent to the user";
            this.checkBox_sendPW.UseVisualStyleBackColor = true;
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(212, 170);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(240, 22);
            this.email_txt.TabIndex = 11;
            // 
            // phone_txt
            // 
            this.phone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.Location = new System.Drawing.Point(212, 205);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(240, 22);
            this.phone_txt.TabIndex = 10;
            // 
            // lastName_txt
            // 
            this.lastName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_txt.Location = new System.Drawing.Point(212, 106);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(240, 22);
            this.lastName_txt.TabIndex = 9;
            // 
            // firstName_txt
            // 
            this.firstName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_txt.Location = new System.Drawing.Point(212, 75);
            this.firstName_txt.Name = "firstName_txt";
            this.firstName_txt.Size = new System.Drawing.Size(240, 22);
            this.firstName_txt.TabIndex = 8;
            // 
            // sendPW_lbl
            // 
            this.sendPW_lbl.AutoSize = true;
            this.sendPW_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendPW_lbl.Location = new System.Drawing.Point(21, 275);
            this.sendPW_lbl.Name = "sendPW_lbl";
            this.sendPW_lbl.Size = new System.Drawing.Size(109, 16);
            this.sendPW_lbl.TabIndex = 7;
            this.sendPW_lbl.Text = "Send password?";
            // 
            // location_lbl
            // 
            this.location_lbl.AutoSize = true;
            this.location_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_lbl.Location = new System.Drawing.Point(21, 242);
            this.location_lbl.Name = "location_lbl";
            this.location_lbl.Size = new System.Drawing.Size(107, 16);
            this.location_lbl.TabIndex = 6;
            this.location_lbl.Text = "Location/branch:";
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lbl.Location = new System.Drawing.Point(21, 208);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(98, 16);
            this.phone_lbl.TabIndex = 5;
            this.phone_lbl.Text = "Phone number:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(21, 173);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(102, 16);
            this.email_lbl.TabIndex = 4;
            this.email_lbl.Text = "E-mail address:";
            // 
            // userType_lbl
            // 
            this.userType_lbl.AutoSize = true;
            this.userType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userType_lbl.Location = new System.Drawing.Point(21, 140);
            this.userType_lbl.Name = "userType_lbl";
            this.userType_lbl.Size = new System.Drawing.Size(86, 16);
            this.userType_lbl.TabIndex = 3;
            this.userType_lbl.Text = "Type of user:";
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_lbl.Location = new System.Drawing.Point(21, 109);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(73, 16);
            this.lastName_lbl.TabIndex = 2;
            this.lastName_lbl.Text = "Last name:";
            // 
            // firstName_lbl
            // 
            this.firstName_lbl.AutoSize = true;
            this.firstName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_lbl.Location = new System.Drawing.Point(21, 78);
            this.firstName_lbl.Name = "firstName_lbl";
            this.firstName_lbl.Size = new System.Drawing.Size(73, 16);
            this.firstName_lbl.TabIndex = 1;
            this.firstName_lbl.Text = "First name:";
            // 
            // CreateUser_lbl
            // 
            this.CreateUser_lbl.AutoSize = true;
            this.CreateUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUser_lbl.Location = new System.Drawing.Point(17, 23);
            this.CreateUser_lbl.Name = "CreateUser_lbl";
            this.CreateUser_lbl.Size = new System.Drawing.Size(165, 24);
            this.CreateUser_lbl.TabIndex = 0;
            this.CreateUser_lbl.Text = "Create new User";
            // 
            // menuDashboard_btn
            // 
            this.menuDashboard_btn.Location = new System.Drawing.Point(1, 38);
            this.menuDashboard_btn.Name = "menuDashboard_btn";
            this.menuDashboard_btn.Size = new System.Drawing.Size(267, 23);
            this.menuDashboard_btn.TabIndex = 5;
            this.menuDashboard_btn.Text = "Dashboard";
            this.menuDashboard_btn.UseVisualStyleBackColor = true;
            this.menuDashboard_btn.Click += new System.EventHandler(this.menuDashboard_btn_Click);
            // 
            // menuIncident_btn
            // 
            this.menuIncident_btn.Location = new System.Drawing.Point(264, 38);
            this.menuIncident_btn.Name = "menuIncident_btn";
            this.menuIncident_btn.Size = new System.Drawing.Size(267, 23);
            this.menuIncident_btn.TabIndex = 7;
            this.menuIncident_btn.Text = "Incident Management";
            this.menuIncident_btn.UseVisualStyleBackColor = true;
            this.menuIncident_btn.Click += new System.EventHandler(this.menuIncident_btn_Click);
            // 
            // menuUser_btn
            // 
            this.menuUser_btn.Location = new System.Drawing.Point(530, 38);
            this.menuUser_btn.Name = "menuUser_btn";
            this.menuUser_btn.Size = new System.Drawing.Size(267, 23);
            this.menuUser_btn.TabIndex = 8;
            this.menuUser_btn.Text = "User Management";
            this.menuUser_btn.UseVisualStyleBackColor = true;
            this.menuUser_btn.Click += new System.EventHandler(this.menuUser_btn_Click);
            // 
            // licensed_lbl
            // 
            this.licensed_lbl.AutoSize = true;
            this.licensed_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensed_lbl.Location = new System.Drawing.Point(610, 25);
            this.licensed_lbl.Name = "licensed_lbl";
            this.licensed_lbl.Size = new System.Drawing.Size(186, 13);
            this.licensed_lbl.TabIndex = 9;
            this.licensed_lbl.Text = "Licensed to: The Garden Group";
            // 
            // NoDesk_lbl
            // 
            this.NoDesk_lbl.AutoSize = true;
            this.NoDesk_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoDesk_lbl.Location = new System.Drawing.Point(716, 5);
            this.NoDesk_lbl.Name = "NoDesk_lbl";
            this.NoDesk_lbl.Size = new System.Drawing.Size(72, 20);
            this.NoDesk_lbl.TabIndex = 10;
            this.NoDesk_lbl.Text = "NoDesk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.licensed_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NoDesk_lbl);
            this.Controls.Add(this.menuUser_btn);
            this.Controls.Add(this.menuIncident_btn);
            this.Controls.Add(this.menuDashboard_btn);
            this.Controls.Add(this.panel_userManagement);
            this.Controls.Add(this.panel_addUser);
            this.Name = "Form1";
            this.Text = "NoSQL application";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel_userManagement.ResumeLayout(false);
            this.panel_userManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.panel_addUser.ResumeLayout(false);
            this.panel_addUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_userManagement;
        private System.Windows.Forms.TextBox filter_txt;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.Label userManagement_lbl;
        private System.Windows.Forms.Panel panel_addUser;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.ComboBox comboBox_userType;
        private System.Windows.Forms.CheckBox checkBox_sendPW;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.TextBox firstName_txt;
        private System.Windows.Forms.Label sendPW_lbl;
        private System.Windows.Forms.Label location_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label userType_lbl;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.Label firstName_lbl;
        private System.Windows.Forms.Label CreateUser_lbl;
        private System.Windows.Forms.Button confirmAddUser_btn;
        private System.Windows.Forms.Button cancelAddUser_btn;
        private System.Windows.Forms.ComboBox comboBox_location;
        private System.Windows.Forms.Label UMError_lbl;
        private System.Windows.Forms.Button menuDashboard_btn;
        private System.Windows.Forms.Button menuIncident_btn;
        private System.Windows.Forms.Button menuUser_btn;
        private System.Windows.Forms.Label licensed_lbl;
        private System.Windows.Forms.Label NoDesk_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace View
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_dashboard = new System.Windows.Forms.Label();
            this.progress_unresolved = new CircularProgressBar.CircularProgressBar();
            this.progress_deadline = new CircularProgressBar.CircularProgressBar();
            this.button_close = new System.Windows.Forms.Button();
            this.label_unresolved = new System.Windows.Forms.Label();
            this.label_deadline = new System.Windows.Forms.Label();
            this.userManagement_panel = new System.Windows.Forms.Panel();
            this.editUser_btn = new System.Windows.Forms.Button();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            this.viewUser_btn = new System.Windows.Forms.Button();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.userFilter_txt = new System.Windows.Forms.TextBox();
            this.userFilter_lbl = new System.Windows.Forms.Label();
            this.dataGridView_userManagement = new System.Windows.Forms.DataGridView();
            this.userManagement_lbl = new System.Windows.Forms.Label();
            this.createUser_panel = new System.Windows.Forms.Panel();
            this.UMError_lbl = new System.Windows.Forms.Label();
            this.createUserConfirm_btn = new System.Windows.Forms.Button();
            this.createUserCancel_btn = new System.Windows.Forms.Button();
            this.checkBox_sendPW = new System.Windows.Forms.CheckBox();
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.comboBox_userType = new System.Windows.Forms.ComboBox();
            this.phoneNumber_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.firstName_txt = new System.Windows.Forms.TextBox();
            this.sendPW_lbl = new System.Windows.Forms.Label();
            this.location_lbl = new System.Windows.Forms.Label();
            this.phoneNumber_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.userType_lbl = new System.Windows.Forms.Label();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.firstName_lbl = new System.Windows.Forms.Label();
            this.addUser_lbl = new System.Windows.Forms.Label();
            this.incidentManagement_panel = new System.Windows.Forms.Panel();
            this.incidentManagement_lbl = new System.Windows.Forms.Label();
            this.dashboard_panel = new System.Windows.Forms.Panel();
            this.dashboardCurrentIncidents_lbl = new System.Windows.Forms.Label();
            this.menuDashboard_btn = new System.Windows.Forms.Button();
            this.menuUserManagement_btn = new System.Windows.Forms.Button();
            this.menuIncidentManagement_btn = new System.Windows.Forms.Button();
            this.createIncident_panel = new System.Windows.Forms.Panel();
            this.createIncident_lbl = new System.Windows.Forms.Label();
            this.NoDesk_lbl = new System.Windows.Forms.Label();
            this.licensed_lbl = new System.Windows.Forms.Label();
            this.editUserConfirm_btn = new System.Windows.Forms.Button();
            this.userId_txt = new System.Windows.Forms.TextBox();
            this.userManagement_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userManagement)).BeginInit();
            this.createUser_panel.SuspendLayout();
            this.incidentManagement_panel.SuspendLayout();
            this.dashboard_panel.SuspendLayout();
            this.createIncident_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_dashboard
            // 
            this.label_dashboard.AutoSize = true;
            this.label_dashboard.Location = new System.Drawing.Point(13, 13);
            this.label_dashboard.Name = "label_dashboard";
            this.label_dashboard.Size = new System.Drawing.Size(59, 13);
            this.label_dashboard.TabIndex = 0;
            this.label_dashboard.Text = "Dashboard";
            // 
            // progress_unresolved
            // 
            this.progress_unresolved.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress_unresolved.AnimationSpeed = 500;
            this.progress_unresolved.BackColor = System.Drawing.Color.Transparent;
            this.progress_unresolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progress_unresolved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progress_unresolved.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progress_unresolved.InnerMargin = 2;
            this.progress_unresolved.InnerWidth = -1;
            this.progress_unresolved.Location = new System.Drawing.Point(85, 108);
            this.progress_unresolved.MarqueeAnimationSpeed = 2000;
            this.progress_unresolved.Name = "progress_unresolved";
            this.progress_unresolved.OuterColor = System.Drawing.Color.Gray;
            this.progress_unresolved.OuterMargin = -25;
            this.progress_unresolved.OuterWidth = 26;
            this.progress_unresolved.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progress_unresolved.ProgressWidth = 25;
            this.progress_unresolved.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress_unresolved.Size = new System.Drawing.Size(255, 255);
            this.progress_unresolved.StartAngle = 270;
            this.progress_unresolved.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_unresolved.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_unresolved.SubscriptText = ".23";
            this.progress_unresolved.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_unresolved.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_unresolved.SuperscriptText = "°C";
            this.progress_unresolved.TabIndex = 1;
            this.progress_unresolved.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progress_unresolved.Value = 68;
            // 
            // progress_deadline
            // 
            this.progress_deadline.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress_deadline.AnimationSpeed = 500;
            this.progress_deadline.BackColor = System.Drawing.Color.Transparent;
            this.progress_deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progress_deadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progress_deadline.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progress_deadline.InnerMargin = 2;
            this.progress_deadline.InnerWidth = -1;
            this.progress_deadline.Location = new System.Drawing.Point(445, 108);
            this.progress_deadline.MarqueeAnimationSpeed = 2000;
            this.progress_deadline.Name = "progress_deadline";
            this.progress_deadline.OuterColor = System.Drawing.Color.Gray;
            this.progress_deadline.OuterMargin = -25;
            this.progress_deadline.OuterWidth = 26;
            this.progress_deadline.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progress_deadline.ProgressWidth = 25;
            this.progress_deadline.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress_deadline.Size = new System.Drawing.Size(255, 255);
            this.progress_deadline.StartAngle = 270;
            this.progress_deadline.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_deadline.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_deadline.SubscriptText = ".23";
            this.progress_deadline.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_deadline.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_deadline.SuperscriptText = "°C";
            this.progress_deadline.TabIndex = 2;
            this.progress_deadline.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progress_deadline.Value = 68;
            this.progress_deadline.Click += new System.EventHandler(this.progress_deadline_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Red;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_close.Location = new System.Drawing.Point(758, -1);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(40, 40);
            this.button_close.TabIndex = 23;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_unresolved
            // 
            this.label_unresolved.AutoSize = true;
            this.label_unresolved.Location = new System.Drawing.Point(159, 77);
            this.label_unresolved.Name = "label_unresolved";
            this.label_unresolved.Size = new System.Drawing.Size(107, 13);
            this.label_unresolved.TabIndex = 24;
            this.label_unresolved.Text = "Unresolved Incidents";
            // 
            // label_deadline
            // 
            this.label_deadline.AutoSize = true;
            this.label_deadline.Location = new System.Drawing.Point(500, 77);
            this.label_deadline.Name = "label_deadline";
            this.label_deadline.Size = new System.Drawing.Size(146, 13);
            this.label_deadline.TabIndex = 25;
            this.label_deadline.Text = "Open incidents past Deadline";
            // 
            // userManagement_panel
            // 
            this.userManagement_panel.Controls.Add(this.editUser_btn);
            this.userManagement_panel.Controls.Add(this.deleteUser_btn);
            this.userManagement_panel.Controls.Add(this.viewUser_btn);
            this.userManagement_panel.Controls.Add(this.addUser_btn);
            this.userManagement_panel.Controls.Add(this.userFilter_txt);
            this.userManagement_panel.Controls.Add(this.userFilter_lbl);
            this.userManagement_panel.Controls.Add(this.dataGridView_userManagement);
            this.userManagement_panel.Controls.Add(this.userManagement_lbl);
            this.userManagement_panel.Location = new System.Drawing.Point(2, 105);
            this.userManagement_panel.Name = "userManagement_panel";
            this.userManagement_panel.Size = new System.Drawing.Size(800, 452);
            this.userManagement_panel.TabIndex = 26;
            // 
            // editUser_btn
            // 
            this.editUser_btn.BackColor = System.Drawing.Color.Khaki;
            this.editUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUser_btn.Location = new System.Drawing.Point(180, 401);
            this.editUser_btn.Name = "editUser_btn";
            this.editUser_btn.Size = new System.Drawing.Size(108, 30);
            this.editUser_btn.TabIndex = 7;
            this.editUser_btn.Text = "Edit User";
            this.editUser_btn.UseVisualStyleBackColor = false;
            this.editUser_btn.Click += new System.EventHandler(this.editUser_btn_Click);
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.BackColor = System.Drawing.Color.Red;
            this.deleteUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteUser_btn.Location = new System.Drawing.Point(314, 401);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(108, 30);
            this.deleteUser_btn.TabIndex = 6;
            this.deleteUser_btn.Text = "Delete User";
            this.deleteUser_btn.UseVisualStyleBackColor = false;
            this.deleteUser_btn.Click += new System.EventHandler(this.deleteUser_btn_Click);
            // 
            // viewUser_btn
            // 
            this.viewUser_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.viewUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUser_btn.Location = new System.Drawing.Point(37, 401);
            this.viewUser_btn.Name = "viewUser_btn";
            this.viewUser_btn.Size = new System.Drawing.Size(108, 30);
            this.viewUser_btn.TabIndex = 5;
            this.viewUser_btn.Text = "View User";
            this.viewUser_btn.UseVisualStyleBackColor = false;
            this.viewUser_btn.Click += new System.EventHandler(this.viewUser_btn_Click);
            // 
            // addUser_btn
            // 
            this.addUser_btn.BackColor = System.Drawing.Color.Chartreuse;
            this.addUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser_btn.Location = new System.Drawing.Point(611, 54);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(154, 43);
            this.addUser_btn.TabIndex = 4;
            this.addUser_btn.Text = "+ ADD NEW USER";
            this.addUser_btn.UseVisualStyleBackColor = false;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // userFilter_txt
            // 
            this.userFilter_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFilter_txt.Location = new System.Drawing.Point(134, 63);
            this.userFilter_txt.Name = "userFilter_txt";
            this.userFilter_txt.Size = new System.Drawing.Size(348, 22);
            this.userFilter_txt.TabIndex = 3;
            this.userFilter_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userFilter_txt_KeyPress);
            // 
            // userFilter_lbl
            // 
            this.userFilter_lbl.AutoSize = true;
            this.userFilter_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFilter_lbl.Location = new System.Drawing.Point(34, 66);
            this.userFilter_lbl.Name = "userFilter_lbl";
            this.userFilter_lbl.Size = new System.Drawing.Size(94, 16);
            this.userFilter_lbl.TabIndex = 2;
            this.userFilter_lbl.Text = "Filter by email:";
            // 
            // dataGridView_userManagement
            // 
            this.dataGridView_userManagement.AllowUserToAddRows = false;
            this.dataGridView_userManagement.AllowUserToDeleteRows = false;
            this.dataGridView_userManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_userManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_userManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_userManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_userManagement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_userManagement.Location = new System.Drawing.Point(34, 111);
            this.dataGridView_userManagement.MultiSelect = false;
            this.dataGridView_userManagement.Name = "dataGridView_userManagement";
            this.dataGridView_userManagement.ReadOnly = true;
            this.dataGridView_userManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_userManagement.Size = new System.Drawing.Size(720, 284);
            this.dataGridView_userManagement.TabIndex = 1;
            // 
            // userManagement_lbl
            // 
            this.userManagement_lbl.AutoSize = true;
            this.userManagement_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagement_lbl.Location = new System.Drawing.Point(29, 25);
            this.userManagement_lbl.Name = "userManagement_lbl";
            this.userManagement_lbl.Size = new System.Drawing.Size(203, 25);
            this.userManagement_lbl.TabIndex = 0;
            this.userManagement_lbl.Text = "User Management";
            // 
            // createUser_panel
            // 
            this.createUser_panel.Controls.Add(this.userId_txt);
            this.createUser_panel.Controls.Add(this.editUserConfirm_btn);
            this.createUser_panel.Controls.Add(this.UMError_lbl);
            this.createUser_panel.Controls.Add(this.createUserConfirm_btn);
            this.createUser_panel.Controls.Add(this.createUserCancel_btn);
            this.createUser_panel.Controls.Add(this.checkBox_sendPW);
            this.createUser_panel.Controls.Add(this.comboBox_location);
            this.createUser_panel.Controls.Add(this.comboBox_userType);
            this.createUser_panel.Controls.Add(this.phoneNumber_txt);
            this.createUser_panel.Controls.Add(this.email_txt);
            this.createUser_panel.Controls.Add(this.lastName_txt);
            this.createUser_panel.Controls.Add(this.firstName_txt);
            this.createUser_panel.Controls.Add(this.sendPW_lbl);
            this.createUser_panel.Controls.Add(this.location_lbl);
            this.createUser_panel.Controls.Add(this.phoneNumber_lbl);
            this.createUser_panel.Controls.Add(this.email_lbl);
            this.createUser_panel.Controls.Add(this.userType_lbl);
            this.createUser_panel.Controls.Add(this.lastName_lbl);
            this.createUser_panel.Controls.Add(this.firstName_lbl);
            this.createUser_panel.Controls.Add(this.addUser_lbl);
            this.createUser_panel.Location = new System.Drawing.Point(2, 103);
            this.createUser_panel.Name = "createUser_panel";
            this.createUser_panel.Size = new System.Drawing.Size(800, 449);
            this.createUser_panel.TabIndex = 27;
            // 
            // UMError_lbl
            // 
            this.UMError_lbl.AutoSize = true;
            this.UMError_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UMError_lbl.ForeColor = System.Drawing.Color.Red;
            this.UMError_lbl.Location = new System.Drawing.Point(247, 25);
            this.UMError_lbl.Name = "UMError_lbl";
            this.UMError_lbl.Size = new System.Drawing.Size(0, 24);
            this.UMError_lbl.TabIndex = 18;
            // 
            // createUserConfirm_btn
            // 
            this.createUserConfirm_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.createUserConfirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserConfirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserConfirm_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.createUserConfirm_btn.Location = new System.Drawing.Point(390, 342);
            this.createUserConfirm_btn.Name = "createUserConfirm_btn";
            this.createUserConfirm_btn.Size = new System.Drawing.Size(107, 55);
            this.createUserConfirm_btn.TabIndex = 16;
            this.createUserConfirm_btn.Text = "ADD USER";
            this.createUserConfirm_btn.UseVisualStyleBackColor = false;
            this.createUserConfirm_btn.Click += new System.EventHandler(this.createUserConfirm_btn_Click);
            // 
            // createUserCancel_btn
            // 
            this.createUserCancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserCancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserCancel_btn.Location = new System.Drawing.Point(251, 342);
            this.createUserCancel_btn.Name = "createUserCancel_btn";
            this.createUserCancel_btn.Size = new System.Drawing.Size(108, 55);
            this.createUserCancel_btn.TabIndex = 15;
            this.createUserCancel_btn.Text = "CANCEL";
            this.createUserCancel_btn.UseVisualStyleBackColor = true;
            this.createUserCancel_btn.Click += new System.EventHandler(this.createUserCancel_btn_Click);
            // 
            // checkBox_sendPW
            // 
            this.checkBox_sendPW.AutoSize = true;
            this.checkBox_sendPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sendPW.Location = new System.Drawing.Point(222, 292);
            this.checkBox_sendPW.Name = "checkBox_sendPW";
            this.checkBox_sendPW.Size = new System.Drawing.Size(297, 20);
            this.checkBox_sendPW.TabIndex = 14;
            this.checkBox_sendPW.Text = "yes, a password e-mail will be sent to the user";
            this.checkBox_sendPW.UseVisualStyleBackColor = true;
            // 
            // comboBox_location
            // 
            this.comboBox_location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Knuppeldam",
            "Headquarters (HQ)"});
            this.comboBox_location.Location = new System.Drawing.Point(222, 253);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(297, 24);
            this.comboBox_location.TabIndex = 13;
            // 
            // comboBox_userType
            // 
            this.comboBox_userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_userType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_userType.FormattingEnabled = true;
            this.comboBox_userType.Items.AddRange(new object[] {
            "Employee",
            "Admin"});
            this.comboBox_userType.Location = new System.Drawing.Point(222, 143);
            this.comboBox_userType.Name = "comboBox_userType";
            this.comboBox_userType.Size = new System.Drawing.Size(297, 24);
            this.comboBox_userType.TabIndex = 12;
            this.comboBox_userType.SelectedIndexChanged += new System.EventHandler(this.comboBox_userType_SelectedIndexChanged);
            // 
            // phoneNumber_txt
            // 
            this.phoneNumber_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_txt.Location = new System.Drawing.Point(222, 214);
            this.phoneNumber_txt.Name = "phoneNumber_txt";
            this.phoneNumber_txt.Size = new System.Drawing.Size(297, 22);
            this.phoneNumber_txt.TabIndex = 11;
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(222, 180);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(297, 22);
            this.email_txt.TabIndex = 10;
            // 
            // lastName_txt
            // 
            this.lastName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_txt.Location = new System.Drawing.Point(222, 108);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(297, 22);
            this.lastName_txt.TabIndex = 9;
            // 
            // firstName_txt
            // 
            this.firstName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_txt.Location = new System.Drawing.Point(222, 68);
            this.firstName_txt.Name = "firstName_txt";
            this.firstName_txt.Size = new System.Drawing.Size(297, 22);
            this.firstName_txt.TabIndex = 8;
            // 
            // sendPW_lbl
            // 
            this.sendPW_lbl.AutoSize = true;
            this.sendPW_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendPW_lbl.Location = new System.Drawing.Point(36, 293);
            this.sendPW_lbl.Name = "sendPW_lbl";
            this.sendPW_lbl.Size = new System.Drawing.Size(109, 16);
            this.sendPW_lbl.TabIndex = 7;
            this.sendPW_lbl.Text = "Send password?";
            // 
            // location_lbl
            // 
            this.location_lbl.AutoSize = true;
            this.location_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_lbl.Location = new System.Drawing.Point(36, 256);
            this.location_lbl.Name = "location_lbl";
            this.location_lbl.Size = new System.Drawing.Size(104, 16);
            this.location_lbl.TabIndex = 6;
            this.location_lbl.Text = "Location/branch";
            // 
            // phoneNumber_lbl
            // 
            this.phoneNumber_lbl.AutoSize = true;
            this.phoneNumber_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_lbl.Location = new System.Drawing.Point(34, 217);
            this.phoneNumber_lbl.Name = "phoneNumber_lbl";
            this.phoneNumber_lbl.Size = new System.Drawing.Size(98, 16);
            this.phoneNumber_lbl.TabIndex = 5;
            this.phoneNumber_lbl.Text = "Phone number:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(36, 183);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(102, 16);
            this.email_lbl.TabIndex = 4;
            this.email_lbl.Text = "E-mail address:";
            // 
            // userType_lbl
            // 
            this.userType_lbl.AutoSize = true;
            this.userType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userType_lbl.Location = new System.Drawing.Point(34, 146);
            this.userType_lbl.Name = "userType_lbl";
            this.userType_lbl.Size = new System.Drawing.Size(83, 16);
            this.userType_lbl.TabIndex = 3;
            this.userType_lbl.Text = "Type of user";
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_lbl.Location = new System.Drawing.Point(34, 111);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(73, 16);
            this.lastName_lbl.TabIndex = 2;
            this.lastName_lbl.Text = "Last name:";
            // 
            // firstName_lbl
            // 
            this.firstName_lbl.AutoSize = true;
            this.firstName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_lbl.Location = new System.Drawing.Point(34, 71);
            this.firstName_lbl.Name = "firstName_lbl";
            this.firstName_lbl.Size = new System.Drawing.Size(73, 16);
            this.firstName_lbl.TabIndex = 1;
            this.firstName_lbl.Text = "First name:";
            // 
            // addUser_lbl
            // 
            this.addUser_lbl.AutoSize = true;
            this.addUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser_lbl.Location = new System.Drawing.Point(29, 25);
            this.addUser_lbl.Name = "addUser_lbl";
            this.addUser_lbl.Size = new System.Drawing.Size(190, 25);
            this.addUser_lbl.TabIndex = 0;
            this.addUser_lbl.Text = "Create New User";
            // 
            // incidentManagement_panel
            // 
            this.incidentManagement_panel.Controls.Add(this.incidentManagement_lbl);
            this.incidentManagement_panel.Location = new System.Drawing.Point(-1, 103);
            this.incidentManagement_panel.Name = "incidentManagement_panel";
            this.incidentManagement_panel.Size = new System.Drawing.Size(800, 452);
            this.incidentManagement_panel.TabIndex = 1;
            // 
            // incidentManagement_lbl
            // 
            this.incidentManagement_lbl.AutoSize = true;
            this.incidentManagement_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentManagement_lbl.Location = new System.Drawing.Point(32, 25);
            this.incidentManagement_lbl.Name = "incidentManagement_lbl";
            this.incidentManagement_lbl.Size = new System.Drawing.Size(192, 25);
            this.incidentManagement_lbl.TabIndex = 0;
            this.incidentManagement_lbl.Text = "Overview Tickets";
            this.incidentManagement_lbl.Click += new System.EventHandler(this.incidentManagement_lbl_Click);
            // 
            // dashboard_panel
            // 
            this.dashboard_panel.Controls.Add(this.dashboardCurrentIncidents_lbl);
            this.dashboard_panel.Controls.Add(this.label_deadline);
            this.dashboard_panel.Controls.Add(this.label_unresolved);
            this.dashboard_panel.Controls.Add(this.progress_deadline);
            this.dashboard_panel.Controls.Add(this.progress_unresolved);
            this.dashboard_panel.Location = new System.Drawing.Point(3, 105);
            this.dashboard_panel.Name = "dashboard_panel";
            this.dashboard_panel.Size = new System.Drawing.Size(799, 450);
            this.dashboard_panel.TabIndex = 27;
            // 
            // dashboardCurrentIncidents_lbl
            // 
            this.dashboardCurrentIncidents_lbl.AutoSize = true;
            this.dashboardCurrentIncidents_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardCurrentIncidents_lbl.Location = new System.Drawing.Point(33, 24);
            this.dashboardCurrentIncidents_lbl.Name = "dashboardCurrentIncidents_lbl";
            this.dashboardCurrentIncidents_lbl.Size = new System.Drawing.Size(192, 25);
            this.dashboardCurrentIncidents_lbl.TabIndex = 26;
            this.dashboardCurrentIncidents_lbl.Text = "Current incidents";
            // 
            // menuDashboard_btn
            // 
            this.menuDashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuDashboard_btn.Location = new System.Drawing.Point(2, 83);
            this.menuDashboard_btn.Name = "menuDashboard_btn";
            this.menuDashboard_btn.Size = new System.Drawing.Size(267, 23);
            this.menuDashboard_btn.TabIndex = 28;
            this.menuDashboard_btn.Text = "Dashboard";
            this.menuDashboard_btn.UseVisualStyleBackColor = true;
            this.menuDashboard_btn.Click += new System.EventHandler(this.menuDashboard_btn_Click);
            // 
            // menuUserManagement_btn
            // 
            this.menuUserManagement_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuUserManagement_btn.Location = new System.Drawing.Point(531, 83);
            this.menuUserManagement_btn.Name = "menuUserManagement_btn";
            this.menuUserManagement_btn.Size = new System.Drawing.Size(267, 23);
            this.menuUserManagement_btn.TabIndex = 29;
            this.menuUserManagement_btn.Text = "User Management";
            this.menuUserManagement_btn.UseVisualStyleBackColor = true;
            this.menuUserManagement_btn.Click += new System.EventHandler(this.menuUsersManagement_btn_Click);
            // 
            // menuIncidentManagement_btn
            // 
            this.menuIncidentManagement_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuIncidentManagement_btn.Location = new System.Drawing.Point(265, 83);
            this.menuIncidentManagement_btn.Name = "menuIncidentManagement_btn";
            this.menuIncidentManagement_btn.Size = new System.Drawing.Size(267, 23);
            this.menuIncidentManagement_btn.TabIndex = 30;
            this.menuIncidentManagement_btn.Text = "Incident Management";
            this.menuIncidentManagement_btn.UseVisualStyleBackColor = true;
            this.menuIncidentManagement_btn.Click += new System.EventHandler(this.menuIncidentManagement_btn_Click);
            // 
            // createIncident_panel
            // 
            this.createIncident_panel.Controls.Add(this.createIncident_lbl);
            this.createIncident_panel.Location = new System.Drawing.Point(3, 103);
            this.createIncident_panel.Name = "createIncident_panel";
            this.createIncident_panel.Size = new System.Drawing.Size(800, 452);
            this.createIncident_panel.TabIndex = 1;
            // 
            // createIncident_lbl
            // 
            this.createIncident_lbl.AutoSize = true;
            this.createIncident_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createIncident_lbl.Location = new System.Drawing.Point(29, 25);
            this.createIncident_lbl.Name = "createIncident_lbl";
            this.createIncident_lbl.Size = new System.Drawing.Size(224, 25);
            this.createIncident_lbl.TabIndex = 0;
            this.createIncident_lbl.Text = "Create New Incident";
            // 
            // NoDesk_lbl
            // 
            this.NoDesk_lbl.AutoSize = true;
            this.NoDesk_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoDesk_lbl.Location = new System.Drawing.Point(704, 42);
            this.NoDesk_lbl.Name = "NoDesk_lbl";
            this.NoDesk_lbl.Size = new System.Drawing.Size(94, 25);
            this.NoDesk_lbl.TabIndex = 31;
            this.NoDesk_lbl.Text = "NoDesk";
            // 
            // licensed_lbl
            // 
            this.licensed_lbl.AutoSize = true;
            this.licensed_lbl.Location = new System.Drawing.Point(641, 67);
            this.licensed_lbl.Name = "licensed_lbl";
            this.licensed_lbl.Size = new System.Drawing.Size(157, 13);
            this.licensed_lbl.TabIndex = 32;
            this.licensed_lbl.Text = "Licensed to: The Garden Group";
            // 
            // editUserConfirm_btn
            // 
            this.editUserConfirm_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.editUserConfirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserConfirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserConfirm_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.editUserConfirm_btn.Location = new System.Drawing.Point(390, 342);
            this.editUserConfirm_btn.Name = "editUserConfirm_btn";
            this.editUserConfirm_btn.Size = new System.Drawing.Size(107, 55);
            this.editUserConfirm_btn.TabIndex = 19;
            this.editUserConfirm_btn.Text = "EDIT USER";
            this.editUserConfirm_btn.UseVisualStyleBackColor = false;
            this.editUserConfirm_btn.Visible = false;
            this.editUserConfirm_btn.Click += new System.EventHandler(this.editUserConfirm_btn_Click);
            // 
            // userId_txt
            // 
            this.userId_txt.Enabled = false;
            this.userId_txt.Location = new System.Drawing.Point(34, 344);
            this.userId_txt.Name = "userId_txt";
            this.userId_txt.ReadOnly = true;
            this.userId_txt.Size = new System.Drawing.Size(100, 20);
            this.userId_txt.TabIndex = 20;
            this.userId_txt.Text = "[hidden textbox]";
            this.userId_txt.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.menuIncidentManagement_btn);
            this.Controls.Add(this.menuUserManagement_btn);
            this.Controls.Add(this.menuDashboard_btn);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_dashboard);
            this.Controls.Add(this.licensed_lbl);
            this.Controls.Add(this.NoDesk_lbl);
            this.Controls.Add(this.createUser_panel);
            this.Controls.Add(this.userManagement_panel);
            this.Controls.Add(this.dashboard_panel);
            this.Controls.Add(this.incidentManagement_panel);
            this.Controls.Add(this.createIncident_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.userManagement_panel.ResumeLayout(false);
            this.userManagement_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userManagement)).EndInit();
            this.createUser_panel.ResumeLayout(false);
            this.createUser_panel.PerformLayout();
            this.incidentManagement_panel.ResumeLayout(false);
            this.incidentManagement_panel.PerformLayout();
            this.dashboard_panel.ResumeLayout(false);
            this.dashboard_panel.PerformLayout();
            this.createIncident_panel.ResumeLayout(false);
            this.createIncident_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dashboard;
        private CircularProgressBar.CircularProgressBar progress_unresolved;
        private CircularProgressBar.CircularProgressBar progress_deadline;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_unresolved;
        private System.Windows.Forms.Label label_deadline;
        private System.Windows.Forms.Panel userManagement_panel;
        private System.Windows.Forms.DataGridView dataGridView_userManagement;
        private System.Windows.Forms.Label userManagement_lbl;
        private System.Windows.Forms.Panel createUser_panel;
        private System.Windows.Forms.Panel incidentManagement_panel;
        private System.Windows.Forms.Label addUser_lbl;
        private System.Windows.Forms.Panel dashboard_panel;
        private System.Windows.Forms.Button menuDashboard_btn;
        private System.Windows.Forms.Button menuUserManagement_btn;
        private System.Windows.Forms.Button menuIncidentManagement_btn;
        private System.Windows.Forms.Label incidentManagement_lbl;
        private System.Windows.Forms.Panel createIncident_panel;
        private System.Windows.Forms.Label createIncident_lbl;
        private System.Windows.Forms.Label NoDesk_lbl;
        private System.Windows.Forms.Label licensed_lbl;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.TextBox userFilter_txt;
        private System.Windows.Forms.Label userFilter_lbl;
        private System.Windows.Forms.ComboBox comboBox_userType;
        private System.Windows.Forms.TextBox phoneNumber_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.TextBox firstName_txt;
        private System.Windows.Forms.Label sendPW_lbl;
        private System.Windows.Forms.Label location_lbl;
        private System.Windows.Forms.Label phoneNumber_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label userType_lbl;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.Label firstName_lbl;
        private System.Windows.Forms.Button createUserConfirm_btn;
        private System.Windows.Forms.Button createUserCancel_btn;
        private System.Windows.Forms.CheckBox checkBox_sendPW;
        private System.Windows.Forms.ComboBox comboBox_location;
        private System.Windows.Forms.Label UMError_lbl;
        private System.Windows.Forms.Label dashboardCurrentIncidents_lbl;
        private System.Windows.Forms.Button editUser_btn;
        private System.Windows.Forms.Button deleteUser_btn;
        private System.Windows.Forms.Button viewUser_btn;
        private System.Windows.Forms.Button editUserConfirm_btn;
        private System.Windows.Forms.TextBox userId_txt;
    }
}
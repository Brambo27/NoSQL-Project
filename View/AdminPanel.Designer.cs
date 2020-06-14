namespace View
{
    partial class AdminPanel
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
            this.StartBackup = new System.Windows.Forms.Button();
            this.backupLocationButton = new System.Windows.Forms.Button();
            this.CheckBoxLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectBackupFileBtn = new System.Windows.Forms.Button();
            this.ReturnBackupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBackup
            // 
            this.StartBackup.Location = new System.Drawing.Point(12, 193);
            this.StartBackup.Name = "StartBackup";
            this.StartBackup.Size = new System.Drawing.Size(276, 58);
            this.StartBackup.TabIndex = 0;
            this.StartBackup.Text = "Make local Backup";
            this.StartBackup.UseVisualStyleBackColor = true;
            this.StartBackup.Click += new System.EventHandler(this.StartBackup_Click);
            // 
            // backupLocationButton
            // 
            this.backupLocationButton.Location = new System.Drawing.Point(12, 12);
            this.backupLocationButton.Name = "backupLocationButton";
            this.backupLocationButton.Size = new System.Drawing.Size(153, 40);
            this.backupLocationButton.TabIndex = 1;
            this.backupLocationButton.Text = "Choose backup location";
            this.backupLocationButton.UseVisualStyleBackColor = true;
            this.backupLocationButton.Click += new System.EventHandler(this.backupLocationButton_Click);
            // 
            // CheckBoxLbl
            // 
            this.CheckBoxLbl.AutoSize = true;
            this.CheckBoxLbl.Location = new System.Drawing.Point(211, 12);
            this.CheckBoxLbl.Name = "CheckBoxLbl";
            this.CheckBoxLbl.Size = new System.Drawing.Size(141, 13);
            this.CheckBoxLbl.TabIndex = 2;
            this.CheckBoxLbl.Text = "Select collections to backup";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 432);
            this.label1.TabIndex = 3;
            // 
            // SelectBackupFileBtn
            // 
            this.SelectBackupFileBtn.Location = new System.Drawing.Point(398, 12);
            this.SelectBackupFileBtn.Name = "SelectBackupFileBtn";
            this.SelectBackupFileBtn.Size = new System.Drawing.Size(153, 40);
            this.SelectBackupFileBtn.TabIndex = 4;
            this.SelectBackupFileBtn.Text = "Choose backup file";
            this.SelectBackupFileBtn.UseVisualStyleBackColor = true;
            this.SelectBackupFileBtn.Click += new System.EventHandler(this.SelectBackupFileBtn_Click);
            // 
            // ReturnBackupBtn
            // 
            this.ReturnBackupBtn.Location = new System.Drawing.Point(398, 193);
            this.ReturnBackupBtn.Name = "ReturnBackupBtn";
            this.ReturnBackupBtn.Size = new System.Drawing.Size(276, 58);
            this.ReturnBackupBtn.TabIndex = 5;
            this.ReturnBackupBtn.Text = "Upload backup to Database";
            this.ReturnBackupBtn.UseVisualStyleBackColor = true;
            this.ReturnBackupBtn.Click += new System.EventHandler(this.ReturnBackupBtn_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnBackupBtn);
            this.Controls.Add(this.SelectBackupFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxLbl);
            this.Controls.Add(this.backupLocationButton);
            this.Controls.Add(this.StartBackup);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button backupLocationButton;
        private System.Windows.Forms.Label CheckBoxLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnBackupBtn;
        private System.Windows.Forms.Button SelectBackupFileBtn;
        private System.Windows.Forms.Button StartBackup;

        #endregion
    }
}
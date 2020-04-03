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
            this.label_dashboard = new System.Windows.Forms.Label();
            this.progress_unresolved = new CircularProgressBar.CircularProgressBar();
            this.progress_deadline = new CircularProgressBar.CircularProgressBar();
            this.button_close = new System.Windows.Forms.Button();
            this.label_unresolved = new System.Windows.Forms.Label();
            this.label_deadline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_dashboard
            // 
            this.label_dashboard.AutoSize = true;
            this.label_dashboard.Location = new System.Drawing.Point(13, 13);
            this.label_dashboard.Name = "label_dashboard";
            this.label_dashboard.Size = new System.Drawing.Size(68, 15);
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
            this.progress_unresolved.Location = new System.Drawing.Point(66, 110);
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
            this.progress_deadline.Location = new System.Drawing.Point(394, 110);
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
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Red;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_close.Location = new System.Drawing.Point(728, 13);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(60, 57);
            this.button_close.TabIndex = 23;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_unresolved
            // 
            this.label_unresolved.AutoSize = true;
            this.label_unresolved.Location = new System.Drawing.Point(135, 71);
            this.label_unresolved.Name = "label_unresolved";
            this.label_unresolved.Size = new System.Drawing.Size(121, 15);
            this.label_unresolved.TabIndex = 24;
            this.label_unresolved.Text = "Unresolved Incidents";
            // 
            // label_deadline
            // 
            this.label_deadline.AutoSize = true;
            this.label_deadline.Location = new System.Drawing.Point(434, 71);
            this.label_deadline.Name = "label_deadline";
            this.label_deadline.Size = new System.Drawing.Size(168, 15);
            this.label_deadline.TabIndex = 25;
            this.label_deadline.Text = "Open incidents past Deadline";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_deadline);
            this.Controls.Add(this.label_unresolved);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.progress_deadline);
            this.Controls.Add(this.progress_unresolved);
            this.Controls.Add(this.label_dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
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
    }
}
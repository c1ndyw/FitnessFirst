namespace FitnessFirst
{
    partial class MainMenuHeader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.musicbutton = new System.Windows.Forms.Button();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.graphBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.achievementBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alertBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // musicbutton
            // 
            this.musicbutton.Location = new System.Drawing.Point(545, 6);
            this.musicbutton.Name = "musicbutton";
            this.musicbutton.Size = new System.Drawing.Size(47, 53);
            this.musicbutton.TabIndex = 17;
            this.musicbutton.Text = "Sound";
            this.musicbutton.UseVisualStyleBackColor = true;
            this.musicbutton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // calendarBtn
            // 
            this.calendarBtn.Location = new System.Drawing.Point(455, 6);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(84, 86);
            this.calendarBtn.TabIndex = 16;
            this.calendarBtn.Text = "Calender";
            this.calendarBtn.UseVisualStyleBackColor = true;
            this.calendarBtn.Click += new System.EventHandler(this.CalendarBtn_Click);
            // 
            // graphBtn
            // 
            this.graphBtn.Location = new System.Drawing.Point(368, 6);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(81, 86);
            this.graphBtn.TabIndex = 15;
            this.graphBtn.Text = "Graph";
            this.graphBtn.UseVisualStyleBackColor = true;
            this.graphBtn.Click += new System.EventHandler(this.GraphBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(283, 6);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(79, 86);
            this.homeBtn.TabIndex = 14;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(100, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(177, 31);
            this.Title.TabIndex = 13;
            this.Title.Text = "Fitness First";
            // 
            // achievementBtn
            // 
            this.achievementBtn.Location = new System.Drawing.Point(640, 6);
            this.achievementBtn.Name = "achievementBtn";
            this.achievementBtn.Size = new System.Drawing.Size(89, 86);
            this.achievementBtn.TabIndex = 18;
            this.achievementBtn.Text = "Achievements";
            this.achievementBtn.UseVisualStyleBackColor = true;
            this.achievementBtn.Click += new System.EventHandler(this.AchievementBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(735, 6);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(89, 86);
            this.logoutBtn.TabIndex = 19;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(91, 89);
            this.logo.TabIndex = 20;
            this.logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alertBtn
            // 
            this.alertBtn.Location = new System.Drawing.Point(587, 23);
            this.alertBtn.Name = "alertBtn";
            this.alertBtn.Size = new System.Drawing.Size(47, 53);
            this.alertBtn.TabIndex = 21;
            this.alertBtn.Text = "Alert";
            this.alertBtn.UseVisualStyleBackColor = true;
            this.alertBtn.Click += new System.EventHandler(this.alertButton_Click);
            // 
            // MainMenuHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alertBtn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.achievementBtn);
            this.Controls.Add(this.musicbutton);
            this.Controls.Add(this.calendarBtn);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.Title);
            this.Name = "MainMenuHeader";
            this.Size = new System.Drawing.Size(836, 95);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button musicbutton;
        private System.Windows.Forms.Button calendarBtn;
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button achievementBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button alertBtn;
    }
}

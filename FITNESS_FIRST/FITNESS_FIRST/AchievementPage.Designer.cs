namespace FitnessFirst
{
    partial class AchievementPage
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
            this.achievementContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // achievementContainer
            // 
            this.achievementContainer.Location = new System.Drawing.Point(3, 3);
            this.achievementContainer.Name = "achievementContainer";
            this.achievementContainer.Size = new System.Drawing.Size(144, 144);
            this.achievementContainer.TabIndex = 0;
            // 
            // AchievementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.achievementContainer);
            this.Name = "AchievementPage";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel achievementContainer;
    }
}

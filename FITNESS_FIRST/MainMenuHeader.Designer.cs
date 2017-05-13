namespace WindowsFormsApplication1
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
            this.settingsBtn = new System.Windows.Forms.Button();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.graphBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(625, 3);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(89, 86);
            this.settingsBtn.TabIndex = 17;
            this.settingsBtn.Text = "Achievements";
            this.settingsBtn.UseVisualStyleBackColor = true;
            // 
            // calendarBtn
            // 
            this.calendarBtn.Location = new System.Drawing.Point(535, 3);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(84, 86);
            this.calendarBtn.TabIndex = 16;
            this.calendarBtn.Text = "Calendar";
            this.calendarBtn.UseVisualStyleBackColor = true;
            // 
            // graphBtn
            // 
            this.graphBtn.Location = new System.Drawing.Point(448, 3);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(81, 86);
            this.graphBtn.TabIndex = 15;
            this.graphBtn.Text = "Graph";
            this.graphBtn.UseVisualStyleBackColor = true;
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(363, 3);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(79, 86);
            this.homeBtn.TabIndex = 14;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fitness First";
            // 
            // MainMenuHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.calendarBtn);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuHeader";
            this.Size = new System.Drawing.Size(720, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button calendarBtn;
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label label1;
    }
}

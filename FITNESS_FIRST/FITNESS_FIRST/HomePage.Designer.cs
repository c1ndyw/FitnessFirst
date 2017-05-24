namespace FitnessFirst
{
    partial class HomePage
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
            this.sportContainer = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // sportContainer
            // 
            this.sportContainer.Location = new System.Drawing.Point(183, 3);
            this.sportContainer.Name = "sportContainer";
            this.sportContainer.Size = new System.Drawing.Size(171, 148);
            this.sportContainer.TabIndex = 9;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(3, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(174, 148);
            this.startBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startBtn.TabIndex = 8;
            this.startBtn.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sportContainer);
            this.Controls.Add(this.startBtn);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(362, 159);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sportContainer;
        private System.Windows.Forms.PictureBox startBtn;
    }
}

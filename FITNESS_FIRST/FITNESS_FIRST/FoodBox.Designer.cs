namespace FitnessFirst
{
    partial class FoodBox
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
            this.desc = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(116, 38);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(30, 13);
            this.desc.TabIndex = 7;
            this.desc.Text = "desc";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(61, 88);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(116, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(23, 13);
            this.title.TabIndex = 4;
            this.title.Text = "title";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(10, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 70);
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            // 
            // FoodBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 125);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.title);
            this.Name = "FoodBox";
            this.Text = "Help";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Help_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox picture;
    }
}
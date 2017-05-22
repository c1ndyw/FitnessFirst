namespace FitnessFirst
{
    partial class FoodPage
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
            this.foodContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // foodContainer
            // 
            this.foodContainer.Location = new System.Drawing.Point(3, 3);
            this.foodContainer.Name = "foodContainer";
            this.foodContainer.Size = new System.Drawing.Size(144, 144);
            this.foodContainer.TabIndex = 0;
            // 
            // FoodPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.foodContainer);
            this.Name = "FoodPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel foodContainer;
    }
}

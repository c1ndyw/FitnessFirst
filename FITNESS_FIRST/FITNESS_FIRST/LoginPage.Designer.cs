namespace FitnessFirst
{
    partial class LoginPage
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
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.forgotPassBtn = new System.Windows.Forms.Button();
            this.newAccBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ForeColor = System.Drawing.Color.Gray;
            this.usernameText.Location = new System.Drawing.Point(23, 158);
            this.usernameText.MaxLength = 8;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(212, 22);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "Username";
            this.usernameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameText_KeyDown);
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.Gray;
            this.passwordText.Location = new System.Drawing.Point(23, 190);
            this.passwordText.MaxLength = 8;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(212, 22);
            this.passwordText.TabIndex = 3;
            this.passwordText.Text = "Password";
            this.passwordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordText_KeyDown);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::FitnessFirst.Properties.Resources.logo1;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(58, 16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(134, 122);
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // logInBtn
            // 
            this.logInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.Location = new System.Drawing.Point(23, 228);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(212, 40);
            this.logInBtn.TabIndex = 10;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // forgotPassBtn
            // 
            this.forgotPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassBtn.Location = new System.Drawing.Point(23, 274);
            this.forgotPassBtn.Name = "forgotPassBtn";
            this.forgotPassBtn.Size = new System.Drawing.Size(212, 40);
            this.forgotPassBtn.TabIndex = 11;
            this.forgotPassBtn.Text = "Forgotten Password?";
            this.forgotPassBtn.UseVisualStyleBackColor = true;
            this.forgotPassBtn.Click += new System.EventHandler(this.forgotPassBtn_Click);
            // 
            // newAccBtn
            // 
            this.newAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccBtn.Location = new System.Drawing.Point(23, 359);
            this.newAccBtn.Name = "newAccBtn";
            this.newAccBtn.Size = new System.Drawing.Size(212, 40);
            this.newAccBtn.TabIndex = 12;
            this.newAccBtn.Text = "Create New Account";
            this.newAccBtn.UseVisualStyleBackColor = true;
            this.newAccBtn.Click += new System.EventHandler(this.newAccBtn_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.newAccBtn);
            this.Controls.Add(this.forgotPassBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(261, 424);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button forgotPassBtn;
        private System.Windows.Forms.Button newAccBtn;
    }
}

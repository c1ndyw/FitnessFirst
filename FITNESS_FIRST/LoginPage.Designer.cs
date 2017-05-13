namespace WindowsFormsApplication1
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.Panel();
            this.forgotPassBtn = new System.Windows.Forms.Panel();
            this.logInLabel = new System.Windows.Forms.Label();
            this.forgotPassLabel = new System.Windows.Forms.Label();
            this.newAccBtn = new System.Windows.Forms.Panel();
            this.newAccLabel = new System.Windows.Forms.Label();
            this.logInBtn.SuspendLayout();
            this.forgotPassBtn.SuspendLayout();
            this.newAccBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(19, 14);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 20);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username :";
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ForeColor = System.Drawing.Color.Gray;
            this.usernameText.Location = new System.Drawing.Point(116, 11);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(119, 26);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "Username";
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.Gray;
            this.passwordText.Location = new System.Drawing.Point(116, 43);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(119, 26);
            this.passwordText.TabIndex = 3;
            this.passwordText.Text = "Password";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(24, 46);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 20);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password :";
            // 
            // logInBtn
            // 
            this.logInBtn.Controls.Add(this.logInLabel);
            this.logInBtn.Location = new System.Drawing.Point(23, 81);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(212, 40);
            this.logInBtn.TabIndex = 4;
            // 
            // forgotPassBtn
            // 
            this.forgotPassBtn.Controls.Add(this.forgotPassLabel);
            this.forgotPassBtn.Location = new System.Drawing.Point(23, 127);
            this.forgotPassBtn.Name = "forgotPassBtn";
            this.forgotPassBtn.Size = new System.Drawing.Size(212, 40);
            this.forgotPassBtn.TabIndex = 5;
            // 
            // logInLabel
            // 
            this.logInLabel.AutoSize = true;
            this.logInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel.Location = new System.Drawing.Point(79, 10);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(54, 20);
            this.logInLabel.TabIndex = 6;
            this.logInLabel.Text = "Log In";
            // 
            // forgotPassLabel
            // 
            this.forgotPassLabel.AutoSize = true;
            this.forgotPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLabel.Location = new System.Drawing.Point(32, 10);
            this.forgotPassLabel.Name = "forgotPassLabel";
            this.forgotPassLabel.Size = new System.Drawing.Size(151, 18);
            this.forgotPassLabel.TabIndex = 7;
            this.forgotPassLabel.Text = "Forgotten Password?";
            // 
            // newAccBtn
            // 
            this.newAccBtn.Controls.Add(this.newAccLabel);
            this.newAccBtn.Location = new System.Drawing.Point(23, 217);
            this.newAccBtn.Name = "newAccBtn";
            this.newAccBtn.Size = new System.Drawing.Size(212, 40);
            this.newAccBtn.TabIndex = 8;
            // 
            // newAccLabel
            // 
            this.newAccLabel.AutoSize = true;
            this.newAccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccLabel.Location = new System.Drawing.Point(28, 10);
            this.newAccLabel.Name = "newAccLabel";
            this.newAccLabel.Size = new System.Drawing.Size(155, 20);
            this.newAccLabel.TabIndex = 7;
            this.newAccLabel.Text = "Create New Account";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newAccBtn);
            this.Controls.Add(this.forgotPassBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameLabel);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(261, 271);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.logInBtn.ResumeLayout(false);
            this.logInBtn.PerformLayout();
            this.forgotPassBtn.ResumeLayout(false);
            this.forgotPassBtn.PerformLayout();
            this.newAccBtn.ResumeLayout(false);
            this.newAccBtn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel logInBtn;
        private System.Windows.Forms.Label logInLabel;
        private System.Windows.Forms.Panel forgotPassBtn;
        private System.Windows.Forms.Label forgotPassLabel;
        private System.Windows.Forms.Panel newAccBtn;
        private System.Windows.Forms.Label newAccLabel;
    }
}

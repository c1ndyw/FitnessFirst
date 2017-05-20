namespace FitnessFirst
{
    partial class RegisterPage
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
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Male_radiobtn = new System.Windows.Forms.RadioButton();
            this.Female_radioBtn = new System.Windows.Forms.RadioButton();
            this.registerBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_txtbox
            // 
            this.password_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtbox.ForeColor = System.Drawing.Color.Black;
            this.password_txtbox.Location = new System.Drawing.Point(119, 157);
            this.password_txtbox.MaxLength = 8;
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '*';
            this.password_txtbox.Size = new System.Drawing.Size(169, 26);
            this.password_txtbox.TabIndex = 4;
            this.password_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_txtbox_KeyDown);
            // 
            // username_txtbox
            // 
            this.username_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtbox.ForeColor = System.Drawing.Color.Black;
            this.username_txtbox.Location = new System.Drawing.Point(119, 118);
            this.username_txtbox.MaxLength = 8;
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(169, 26);
            this.username_txtbox.TabIndex = 3;
            this.username_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_txtbox_KeyDown);
            // 
            // email_txtbox
            // 
            this.email_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txtbox.ForeColor = System.Drawing.Color.Black;
            this.email_txtbox.Location = new System.Drawing.Point(119, 79);
            this.email_txtbox.MaxLength = 80;
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(169, 26);
            this.email_txtbox.TabIndex = 2;
            this.email_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_txtbox_KeyDown);
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.ForeColor = System.Drawing.Color.Black;
            this.name_txtbox.Location = new System.Drawing.Point(119, 43);
            this.name_txtbox.MaxLength = 30;
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(169, 26);
            this.name_txtbox.TabIndex = 1;
            this.name_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_txtbox_KeyDown);
            this.name_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stringOnly);
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.Location = new System.Drawing.Point(37, 192);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(63, 20);
            this.GenderLbl.TabIndex = 5;
            this.GenderLbl.Text = "Gender";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(22, 157);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(78, 20);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Password";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(17, 116);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(83, 20);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "Username";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(52, 79);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(48, 20);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "Email";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(49, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // Male_radiobtn
            // 
            this.Male_radiobtn.AutoSize = true;
            this.Male_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male_radiobtn.Location = new System.Drawing.Point(119, 194);
            this.Male_radiobtn.Name = "Male_radiobtn";
            this.Male_radiobtn.Size = new System.Drawing.Size(61, 24);
            this.Male_radiobtn.TabIndex = 24;
            this.Male_radiobtn.TabStop = true;
            this.Male_radiobtn.Text = "Male";
            this.Male_radiobtn.UseVisualStyleBackColor = true;
            this.Male_radiobtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Male_radiobtn_KeyDown);
            // 
            // Female_radioBtn
            // 
            this.Female_radioBtn.AutoSize = true;
            this.Female_radioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female_radioBtn.Location = new System.Drawing.Point(208, 194);
            this.Female_radioBtn.Name = "Female_radioBtn";
            this.Female_radioBtn.Size = new System.Drawing.Size(80, 24);
            this.Female_radioBtn.TabIndex = 25;
            this.Female_radioBtn.TabStop = true;
            this.Female_radioBtn.Text = "Female";
            this.Female_radioBtn.UseVisualStyleBackColor = true;
            this.Female_radioBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Female_radioBtn_KeyDown);
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(26, 239);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(262, 40);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(26, 285);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(262, 40);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(26, 349);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(262, 40);
            this.backBtn.TabIndex = 26;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.Female_radioBtn);
            this.Controls.Add(this.Male_radiobtn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.NameLabel);
            this.Name = "RegisterPage";
            this.Size = new System.Drawing.Size(317, 402);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.RadioButton Male_radiobtn;
        private System.Windows.Forms.RadioButton Female_radioBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button backBtn;
    }
}

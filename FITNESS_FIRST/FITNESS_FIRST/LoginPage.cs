using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FitnessFirst
{
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
            Initialization();
        }

        public void Initialization()
        {
            InitializeLogo();
            InitializeButtons();
            InitializeInputs();
        }

        private void InitializeLogo()
        {
            logo.Location = new Point(20, 15);
            logo.Size = new System.Drawing.Size(this.Width - 40, 140);
            logo.BackColor = Color.Transparent;
        }

        private void InitializeButtons()
        {
            logInBtn.BackColor = Color.DarkRed;
            logInBtn.ForeColor = Color.White;
            logInBtn.FlatAppearance.BorderSize = 0;
            logInBtn.FlatStyle = FlatStyle.Flat;
            logInBtn.Cursor = Cursors.Hand;
            logInBtn.Font = Global.CustomFont;
            forgotPassBtn.FlatAppearance.BorderSize = 0;
            forgotPassBtn.FlatStyle = FlatStyle.Flat;
            forgotPassBtn.Cursor = Cursors.Hand;
            forgotPassBtn.Font = Global.CustomFont;
            newAccBtn.FlatAppearance.BorderSize = 0;
            newAccBtn.FlatStyle = FlatStyle.Flat;
            newAccBtn.Cursor = Cursors.Hand;
            newAccBtn.Font = Global.CustomFont;
        }

        void usernameText_GotFocus(object sender, EventArgs e)
        {
            if (usernameText.Text == "username" && usernameText.ForeColor == Color.Gray)
            {
                usernameText.Text = "";
                usernameText.ForeColor = Color.Black;
            }
        }

        void passwordText_GotFocus(object sender, EventArgs e)
        {
            if (passwordText.Text == "password" && passwordText.ForeColor == Color.Gray)
            {
                passwordText.Text = "";
                passwordText.ForeColor = Color.Black;
                passwordText.PasswordChar = '*';
            }
        }

        private void InitializeInputs()
        {
            usernameText.Font = Global.InputFont2;
            usernameText.GotFocus += usernameText_GotFocus;
            usernameText.LostFocus += usernameText_LostFocus;
            passwordText.Font = Global.InputFont2;
            passwordText.GotFocus += passwordText_GotFocus;
            passwordText.LostFocus += passwordText_LostFocus;
            usernameText.Text = "username";
            passwordText.Text = "password";
        }

        void usernameText_LostFocus(object sender, EventArgs e)
        {
            if (usernameText.Text == "")
            {
                usernameText.Text = "username";
                usernameText.ForeColor = Color.Gray;
            }
        }

        void passwordText_LostFocus(object sender, EventArgs e)
        {
            if (passwordText.Text == "")
            {
                passwordText.Text = "password";
                passwordText.ForeColor = Color.Gray;
                passwordText.PasswordChar = '\0';
            }
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawLine(pen, usernameText.Location.X, usernameText.Location.Y + usernameText.Height + 2, usernameText.Location.X + usernameText.Width, usernameText.Location.Y + usernameText.Height + 2);
            e.Graphics.DrawLine(pen, passwordText.Location.X, passwordText.Location.Y + passwordText.Height + 2, passwordText.Location.X + passwordText.Width, passwordText.Location.Y + passwordText.Height + 2);
        }

        public Results TryLogin()
        {
            if (Global.Authenticate(usernameText.Text, passwordText.Text))
            {
                Global.ChangePage(Pages.MainPage);
                return Results.Success;
            }
            return Results.Failed;
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void forgotPassBtn_Click(object sender, EventArgs e)
        {
            Global.ChangePage(Pages.ForgotPasswordPage);
            MessageBox.Show("Please remember your account.");
        }

        private void newAccBtn_Click(object sender, EventArgs e)
        {
            Global.ChangePage(Pages.RegisterPage);
            //Window parent = (Window)Parent;
            //parent.Controls.RemoveAt(0);
            //parent.Controls.Add(parent.RegisterPage);
        }

        public void Reset()
        {
            usernameText.ForeColor = Color.Gray;
            usernameText.Font = new Font(FontFamily.GenericSansSerif, 14.0f, FontStyle.Italic);
            usernameText.Text = "username";
            passwordText.ForeColor = Color.Gray;
            passwordText.PasswordChar = '\0';
            passwordText.Font = new Font(FontFamily.GenericSansSerif, 14.0f, FontStyle.Italic);
            passwordText.Text = "password";
        }

        public string UsernameTextBox
        {
            get
            {
                return usernameText.Text;
            }
            set
            {
                usernameText.Text = value;
            }
        }
        public string PasswordTextBox
        {
            get
            {
                return passwordText.Text;
            }
            set
            {
                passwordText.Text = value;
            }
        }

        public bool isNotEmptyField()
        {
            if (usernameText.Text == "Username" && passwordText.Text == "Password")
            {
                return true;
            }
            return false;
        }

        private void usernameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                passwordText.Focus();
            }
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logInBtn.Focus();
            }
        }
    }
}

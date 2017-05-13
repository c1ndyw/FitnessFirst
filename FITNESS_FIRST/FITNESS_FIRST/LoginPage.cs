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
        Button[] _buttons = new Button[3];

        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            logInBtn.BackColor = Color.DarkRed;
            logInBtn.ForeColor = Color.White;
            logInBtn.FlatAppearance.BorderSize = 0;
            logInBtn.FlatStyle = FlatStyle.Flat;
            logInBtn.Cursor = Cursors.Hand;
            forgotPassBtn.FlatAppearance.BorderSize = 0;
            forgotPassBtn.FlatStyle = FlatStyle.Flat;
            forgotPassBtn.Cursor = Cursors.Hand;
            newAccBtn.FlatAppearance.BorderSize = 0;
            newAccBtn.FlatStyle = FlatStyle.Flat;
            newAccBtn.Cursor = Cursors.Hand;
            loginName();
            forgotPassBtn.Name = "forgotPass";
            newAccBtn.Name = "newAcc";
            _buttons[0] = logInBtn;
            _buttons[1] = forgotPassBtn;
            _buttons[2] = newAccBtn;
        }
        public bool loginName() {
            logInBtn.Name = "logIn";
            return true;
        }
        public Button getButton(string buttonName)
        {
            foreach (Button button in _buttons)
            {
                if (button.Name == buttonName)
                {
                    return button;
                }
            }
            return null;
        }

        public bool login()
        {
            return Global.Authenticate(usernameText.Text, passwordText.Text);
            //return true;
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            if (usernameText.Text == "username")
            {
                usernameText.Text = "";
                usernameText.ForeColor = Color.Black;
                usernameText.Font = new Font(FontFamily.GenericSansSerif, 12.0f, FontStyle.Regular);
            } 
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawLine(pen, usernameText.Location.X, usernameText.Location.Y + usernameText.Height + 2, usernameText.Location.X + usernameText.Width, usernameText.Location.Y + usernameText.Height + 2);
            e.Graphics.DrawLine(pen, passwordText.Location.X, passwordText.Location.Y + passwordText.Height + 2, passwordText.Location.X + passwordText.Width, passwordText.Location.Y + passwordText.Height + 2);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            usernameText.Text = "";
            passwordText.Text = "";
        }

        public bool isNotEmptyField() {
            if (usernameText.Text == "Username" && passwordText.Text == "Password") {
                return true;
            }
            return false ;
        }
        private void logInBtn_Click(object sender, EventArgs e)
        {
            
        }

        public string UsernameTextBox{
            get {
                return usernameText.Text;
            }
            set {
                usernameText.Text = value;
            }
         }
        public string PasswordTextBox {
            get {
                return passwordText.Text;
            }
            set {
                passwordText.Text = value;
            }
        }

        private void login(object sender, EventArgs e)
        {
            if (usernameText.Text != "Username" && passwordText.Text != "Password")
            {
                Window parent = (Window)Parent;
                parent.login();
            }
            else {
                MessageBox.Show("Insert Correct Username and Password!");
            }
            
        }

        private void forgotPass(object sender, EventArgs e)
        {
            Window parent = (Window)Parent;
            //parent.Controls.RemoveAt(0);
            //parent.Controls.Add(parent._mainPage);
        }

        private void newAcc(object sender, EventArgs e)
        {
            Window parent = (Window)Parent;
            parent.Controls.RemoveAt(0);
            parent.Controls.Add(parent._registerPage);
        }
    }
}

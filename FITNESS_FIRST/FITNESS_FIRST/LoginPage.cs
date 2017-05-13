using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LoginPage : UserControl
    {
        Panel[] _buttons = new Panel[3];

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            logInBtn.BackColor = Color.DarkBlue;
            logInBtn.ForeColor = Color.White;
            forgotPassLabel.ForeColor = Color.DarkBlue;
            newAccLabel.ForeColor = Color.DarkBlue;
            logInBtn.Name = "logIn";
            forgotPassBtn.Name = "forgotPass";
            newAccBtn.Name = "newAcc";
            _buttons[0] = logInBtn;
            _buttons[1] = forgotPassBtn;
            _buttons[2] = newAccBtn;
        }

        public Panel getButton(string buttonName)
        {
            foreach (Panel button in _buttons)
            {
                if (button.Name == buttonName)
                {
                    return button;
                }
            }
            return null;
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
    }
}

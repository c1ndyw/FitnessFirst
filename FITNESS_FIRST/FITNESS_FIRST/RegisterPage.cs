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
    public partial class RegisterPage : UserControl
    {
        private Window _window;
        public RegisterPage()
        {
            InitializeComponent();
            Male_radiobtn.Checked = true;
        }

        public void Init(Window w)
        {
            _window = w;
            registerBtn.BackColor = Color.DarkRed;
            registerBtn.ForeColor = Color.White;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = Global.ButtonFont;
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = Global.ButtonFont;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = Global.ButtonFont;
            NameLabel.Font = Global.CustomFont;
            EmailLbl.Font = Global.CustomFont;
            UsernameLbl.Font = Global.CustomFont;
            PasswordLbl.Font = Global.CustomFont;
            GenderLbl.Font = Global.CustomFont;
            name_txtbox.Font = Global.InputFont2;
            email_txtbox.Font = Global.InputFont2;
            username_txtbox.Font = Global.InputFont2;
            password_txtbox.Font = Global.InputFont2;
            Male_radiobtn.Font = Global.CustomFont;
            Female_radioBtn.Font = Global.CustomFont;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            reset();
            Global.ChangePage(Pages.LoginPage);
        }

        private void stringOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public bool CorrectInputFormat()
        {
            if (Global.UsedUser(username_txtbox.Text))
            {
                MessageBox.Show("Username has been used");
                return false;
            }
            if (string.IsNullOrWhiteSpace(name_txtbox.Text) /*int.TryParse(name_txtbox.Text, out numberReturn)*/)
            {
                MessageBox.Show("Name field needs to be completed!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(username_txtbox.Text) || username_txtbox.Text.Length > 8)
            {
                if (username_txtbox.Text.Length > 8)
                {
                    MessageBox.Show("Username cannot be more than 8 characters!");
                }
                else
                {
                    MessageBox.Show("username field needs to be completed!");
                }
                return false;
            }
            if (string.IsNullOrWhiteSpace(password_txtbox.Text) || password_txtbox.Text.Length > 8)
            {
                if (password_txtbox.Text.Length > 8)
                {
                    MessageBox.Show("Password cannot be more than 8 characters!");
                }
                else
                {
                    MessageBox.Show("Password field needs to be completed!");
                }
                return false;
            }
            if (string.IsNullOrWhiteSpace(email_txtbox.Text))
            {
                MessageBox.Show("Email cannot be number!");
                return false;
            }
            else if (!email_txtbox.Text.Contains('@') || !email_txtbox.Text.Contains('.') || email_txtbox.Text.IndexOf('.') < email_txtbox.Text.IndexOf('@'))
            {
                MessageBox.Show("Incorrect email format!");
                return false;
            }

            return true;
        }

        public void insertData()
        {

            if (CorrectInputFormat())
            {
                string gender;
                if (Female_radioBtn.Checked)
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }
                try
                {
                    string query = "INSERT into [user] (Name,Username,Password,Points,Highscore,Email,Gender) values (@Name,@Username,@Password,0,0,@Email,@Gender)";
                    SqlCommand cmd = new SqlCommand(query, Global.conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", name_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Username", username_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Password", password_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Email", email_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    Global.conn.Open();
                    cmd.ExecuteNonQuery();
                    Global.conn.Close();
                    MessageBox.Show("New user is created!");
                    reset();
                    Global.ChangePage(Pages.LoginPage);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {

            name_txtbox.Text = "";
            username_txtbox.Text = "";
            email_txtbox.Text = "";
            password_txtbox.Text = "";
            Male_radiobtn.Checked = true;
            Female_radioBtn.Checked = false;


        }

        private void name_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                email_txtbox.Focus();
            }
        }

        private void email_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                username_txtbox.Focus();
            }
        }

        private void username_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("test");
                password_txtbox.Focus();
            }
        }

        private void password_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("test");
                Male_radiobtn.Focus();
            }
        }

        private void Male_radiobtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                registerBtn.Focus();
            }

        }

        private void Female_radioBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerBtn.Focus();
            }
        }

        public string NameTextBox
        {
            get { return name_txtbox.Text; }
            set { name_txtbox.Text = value; }
        }
        public string EmailTextBox
        {
            get
            {
                return email_txtbox.Text;
            }
            set
            {
                email_txtbox.Text = value;
            }
        }
        public string UsernameTextBox
        {
            get
            {
                return username_txtbox.Text;
            }
            set
            {
                username_txtbox.Text = value;
            }
        }
        public string PasswordTextBox
        {
            get
            {
                return password_txtbox.Text;
            }
            set
            {
                password_txtbox.Text = value;
            }
        }
        public char GenderRadiobutton
        {
            get
            {
                if (Male_radiobtn.Checked) { return 'M'; } else { return 'F'; }
            }


        }
        public RadioButton FemaleChecked
        {
            get
            {
                return Female_radioBtn;
            }
            set
            {
                Female_radioBtn = value;
            }
        }
        public RadioButton MaleChecked
        {
            set
            {
                Male_radiobtn = value;
            }
        }
    }
}

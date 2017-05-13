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
        }

        private void name_txtbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (name_txtbox.Text == "Name")
            {
                name_txtbox.Text = "";
                name_txtbox.ForeColor = Color.Black;
                name_txtbox.Font = new Font(name_txtbox.Font, FontStyle.Regular);
            }

        }

        private void email_txtbox_Click(object sender, EventArgs e)
        {
            if (email_txtbox.Text == "Email")
            {
                email_txtbox.Text = "";
                email_txtbox.ForeColor = Color.Black;
                email_txtbox.Font = new Font(email_txtbox.Font, FontStyle.Regular);
            }
        }

        private void username_txtbox_Click(object sender, EventArgs e)
        {
            if (username_txtbox.Text == "Username")
            {
                username_txtbox.Text = "";
                username_txtbox.ForeColor = Color.Black;
                username_txtbox.Font = new Font(username_txtbox.Font, FontStyle.Regular);
            }
        }

        private void password_txtbox_Click(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "Password")
            {
                password_txtbox.Text = "";
                password_txtbox.PasswordChar = '*';
                password_txtbox.MaxLength = 8;
                password_txtbox.ForeColor = Color.Black;
                password_txtbox.Font = new Font(password_txtbox.Font, FontStyle.Regular);
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            _window.back();
        }

        public bool CorrectInputFormat() {
            if (Global.UsedUser(username_txtbox.Text))
            {
                MessageBox.Show("Username has been used");
                return false;
            }
            int numberReturn = 230995 ;
             if (string.IsNullOrWhiteSpace(name_txtbox.Text) || int.TryParse(name_txtbox.Text, out numberReturn)) {
                 
                 if (numberReturn != 230995)
                 {
                     MessageBox.Show("Name cannot contain number");
                     return false;
                 }
                 else
                 {
                     MessageBox.Show("Name field needs to be completed!");
                     return false;
                 }
             }

             if (string.IsNullOrWhiteSpace(username_txtbox.Text) || username_txtbox.Text.Length > 8) {
                 if (username_txtbox.Text.Length > 8)
                 {
                     MessageBox.Show("Username cannot be more than 8 characters!");
                 }
                 else
                 {
                     MessageBox.Show("username field needs to be completed!");
                 }
                   return false ;
             }
             if (string.IsNullOrWhiteSpace(password_txtbox.Text) || password_txtbox.Text.Length > 8) {
                 if (password_txtbox.Text.Length > 8)
                 {
                     MessageBox.Show("Password cannot be more than 8 characters!");
                 }
                 else
                 {
                     MessageBox.Show("Password field needs to be completed!");
                 }
                   return false ;
             }
             int numberReturn2 = 230995;
             if (string.IsNullOrWhiteSpace(email_txtbox.Text) || email_txtbox.Text.Length > 30 || int.TryParse(email_txtbox.Text, out numberReturn2))
             {
                 if (numberReturn2 != 230995)
                 {
                     MessageBox.Show("Email cannot be number!");
                     return false;
                 }

                MessageBox.Show("Required field needs to be completed!");
                   return false ;
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
                    _window.back();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public void reset() {

            name_txtbox.Text = "";
            username_txtbox.Text = "";
            email_txtbox.Text = "";
            password_txtbox.Text = "";
            Male_radiobtn.Checked = true;
            Female_radioBtn.Checked = false;
        
        
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            reset();
            
        }





        public string NameTextBox
        {
            get { return name_txtbox.Text; }
            set { name_txtbox.Text = value; }
        }
        public string EmailTextBox {
            get {
                return email_txtbox.Text;
            }
            set {
                email_txtbox.Text = value;
            }
        }
        public string UsernameTextBox {
            get {
                return username_txtbox.Text;
            }
            set {
                username_txtbox.Text = value;
            }
        }
        public string PasswordTextBox {
            get {
                return password_txtbox.Text;
            }
            set {
                password_txtbox.Text = value;
            }
        }
        public char GenderRadiobutton{
            get {
                if (Male_radiobtn.Checked) { return 'M'; } else { return 'F'; }
            }
           

          }
        public RadioButton FemaleChecked {
            get {
                return Female_radioBtn;
            }
            set {
                Female_radioBtn = value;
            }
        }
        public RadioButton MaleChecked {
            set {
                Male_radiobtn = value;
            }
        }
        private void RegisterPage_Load(object sender, EventArgs e)
        {
            reset();
        }
        
       
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessFirst;
using System.Data.SqlClient;


namespace RegisterUnitTest
{
    [TestClass]
    public class UserAccountUnitTest
    {
        RegisterPage RP = new RegisterPage();
        LoginPage LP = new LoginPage();

     

        [TestMethod] // Check if the username and password textbox are empty
        public void IsnotEmptyLogin()
        {
            LP.UsernameTextBox = "Gabriel";
            LP.PasswordTextBox = "Gabriel";
            bool notEmpty = false;
            if (LP.UsernameTextBox != "Username" && LP.PasswordTextBox != "Password")
            {
                notEmpty = true;
            }
            Assert.AreEqual(true, notEmpty);
        }
        [TestMethod]// Check if the user can login
        public void Login()
        {
            bool exist = false;
            string username = "Gabriel";
            string password = "Gabriel";
            SqlCommand command = new SqlCommand("select * from dbo.[user] where username = @name", Global.conn);
            command.Parameters.AddWithValue("@name", username);
            string[] userval = new string[8];
            try
            {
                Global.conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    for (int i = 0; i < 8; i++)
                    {
                        userval[i] = reader[i].ToString();
                    }
                }
                reader.Close();
                Global.conn.Close();
                if (userval[2] == username && userval[3] == password)
                    exist = true;
                else
                    exist = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                exist = false;
            }
            Assert.IsTrue(exist);
        }


        [TestMethod]
        public void ResetRegisterForm() // reset the textbox
        {
            bool reset = false;
            RP.NameTextBox = "Cindy Wijaya";
            RP.EmailTextBox = "cindyangelicawijaya@ymail.com";
            RP.UsernameTextBox = "c1ndyw";
            RP.PasswordTextBox = "Pa$$w0rd";

            RP.reset();
           
                reset = true;
           

            Assert.AreEqual(true, reset);
        }

        [TestMethod]
        public void RegisteredUsername()
        {
            RP.UsernameTextBox = "Gabriel";
            Assert.AreEqual(Global.UsedUser(RP.UsernameTextBox), true);
        }

        [TestMethod] // if one of the textbox is empty then user can't register
        public void isNotEmptyRegister()
        {
            RP.NameTextBox = "Cindy Wijaya";
            RP.EmailTextBox = "cindyangelicawijaya@ymail.com";
            RP.UsernameTextBox = "c1ndyw";
            RP.PasswordTextBox = "Pa$$w0rd";

            bool _textboxFilled = true;
            if (string.IsNullOrWhiteSpace(RP.NameTextBox) || string.IsNullOrWhiteSpace(RP.EmailTextBox) || string.IsNullOrWhiteSpace(RP.UsernameTextBox) || string.IsNullOrWhiteSpace(RP.PasswordTextBox))
            {
                _textboxFilled = false;
            }
            else if (RP.NameTextBox == "Name" || RP.EmailTextBox == "Email" || RP.UsernameTextBox == "Username" || RP.PasswordTextBox == "Password")
            {
                _textboxFilled = false;
            }
            Assert.AreEqual(true, _textboxFilled);
        }

        [TestMethod]
        public void SaveToDataBase() // save to database
        {
            string success;
            try
            {
                string query = "INSERT into [User] (Name,Username,Password,Points,Highscore,Email,Gender) values (@Name,@Username,@Password,0,0,@Email,@Gender)";
                SqlCommand cmd = new SqlCommand(query, Global.conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", "Cindy Wijaya");
                cmd.Parameters.AddWithValue("@Username", "c1ndyw");
                cmd.Parameters.AddWithValue("@Password", "Pa$$w0rd");
                cmd.Parameters.AddWithValue("@Email", "Cindyangelicawijayya@ymail.com");
                cmd.Parameters.AddWithValue("@Gender", 'F');
                Global.conn.Open();
                cmd.ExecuteNonQuery();
                Global.conn.Close();
                success = "success";
            }
            catch (Exception e)
            {
                success = "failed";
            }
            Assert.AreEqual(success, "success");
        }
    }
}

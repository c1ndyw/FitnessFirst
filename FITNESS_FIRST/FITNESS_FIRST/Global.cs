using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace FitnessFirst
{
    public class Global
    {
        private static string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Fitnessfirst.mdf";
        private static string connString2 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\SoftwaresFiles\VisualStudio\FITNESS_FIRST\FITNESS_FIRST\Fitnessfirst.mdf";
        public static SqlConnection conn = new SqlConnection(connString);
        public static SqlConnection conn2 = new SqlConnection(connString2);
        public static int ButtonSize = 100, exerciseTime = 10;
        public static Sports CurrentSport;
        public static List<Achievement> Achievements = new List<Achievement>();
        public static List<Achievement> DefaultAchievements = new List<Achievement>();
        public static List<Food> DefaultFoods = new List<Food>();
        public static User user = null;
        public static Window Window { get; set; }
        public static Font ButtonFont = new Font("Kartika", 12, FontStyle.Regular);
        public static Font TitleFont = new Font("Kartika", 24, FontStyle.Bold);
        public static Font TitleFont2 = new Font("Kartika", 16, FontStyle.Bold);
        public static Font InputFont = new Font("Kartika", 12, FontStyle.Regular);
        public static Font InputFont2 = new Font("Kartika", 12, FontStyle.Regular);
        public static Font CustomFont = new Font("Kartika", 12, FontStyle.Regular);
        public static Font CustomFont2 = new Font("Kartika", 14, FontStyle.Regular);
        private static Pages CurrentPage = Pages.LoginPage;

        public static Results ChangePage(Pages page) {
            if (page != CurrentPage)
            {
                CurrentPage = page;
                return Window.ChangeWindow(page);
            }
            return Results.Failed;
        }

        public static void SetDefaultAchievements()
        {
            DefaultAchievements = new List<Achievement>();
            DefaultAchievements.Add(new Achievement("First Exercise", "Good job on your first exercise", "How to Get: get to exercise 1 time.", Properties.Resources.Bronze));
            DefaultAchievements.Add(new Achievement("Appretice Training", "Great! Keep that up!", "How to Get: get to exercise 3 time.", Properties.Resources.Silver));
            DefaultAchievements.Add(new Achievement("Hardworker", "Training, training, training!", "How to Get: get to exercise 5 time.", Properties.Resources.Gold));
            DefaultAchievements.Add(new Achievement("Workaholic", "Muscle is the best!", "How to Get: get to exercise 10 time.", Properties.Resources.Platinum));
        }

        public static void SetDefaultFoods()
        {
            DefaultFoods = new List<Food>();
            DefaultFoods.Add(new Food("Banana", "Eating a medium banana with ½ cup of\nGreek yogurt before do exercise 30 minutes\nwould aids in maintaining nerve and muscle\nfunction.", "", Properties.Resources._1_banana));
            DefaultFoods.Add(new Food("Oats", "Eating one cup of oats at least 30 minutes\nbefore you begin exercising would help you\nrelease carbohydrates into your bloodstream\nand convert carbohydrates into energy.", "", Properties.Resources._2_oats));
            DefaultFoods.Add(new Food("Wholegrain Bread", "if you’re doing exercise during your lunch\n break, grab some bread about 45 minutes\nbefore. That provides carbohydrates and\nprotein for your body.", "", Properties.Resources._3_bread));
            DefaultFoods.Add(new Food("Fruit", "The carbohydrates from fruits break down\n quickly to become fuel for a workout and\nthe protein is used later to prevent muscle\ndamage.", "", Properties.Resources._4_fruit));
            DefaultFoods.Add(new Food("Omelette", "Eating omelettes 2-3 hours before a workout\n would help you avoid catabolism and\npromote muscle growth.", "", Properties.Resources._5_omelette));
            DefaultFoods.Add(new Food("Chicken", "Serving chicken with rice and vegetables 2-3\n hours before doing exercise would provide\namino acids to promote muscle anabolism and\na slow releasing source of energy.", "", Properties.Resources._6_chicken));
            DefaultFoods.Add(new Food("Apple and Peanut Butter", "Enjoying sliced apple wedges with a small\n spread of peanut butter is perfect for\nconsuming 30 minutes before a workout!", "", Properties.Resources._7_apple));
            DefaultFoods.Add(new Food("Greek Yogurt", "Serving dried fruit with Greek yogurt 1-1.5\n hours before workout can provide the body\nwith a source of protein to help optimise\nyour workout.", "", Properties.Resources._8_greekYogurt));
        }

        public static bool Authenticate(string username, string password)
        {
            if (SetUserDetails(username, password))
            {
                if (user.username == username && user.password == password)
                {
                    GetAchievements();
                    return true;
                }
            }
            MessageBox.Show("Username or password incorrect");
            return false;
        }

        public static bool UsedUser(string username)
        {
            SqlCommand command = new SqlCommand("select username from [user] where username = @username", conn);
            command.Parameters.AddWithValue("@username", username);
            try
            {
                String exist;
                conn.Open();
                exist = Convert.ToString(command.ExecuteScalar());
                conn.Close();

                if (exist == username)
                {
                    MessageBox.Show("exist user :" + exist);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

        }

        public static int GetExerciseCount()
        {
            SqlCommand command = new SqlCommand("select * from [Exercise] where userid = @userid", conn);
            command.Parameters.AddWithValue("@userid", user.id);
            int count = 0;
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    count += Convert.ToInt32(reader[3]);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //MessageBox.Show("Connection to database failed");
            }
            return count;
        }

        public static int SynchronizeAchievement()
        {
            int exercisecount = GetExerciseCount();
            int getachievement = 0;
            if (exercisecount >= 1)
            {
                if (AddAchievement(DefaultAchievements[0].title))
                    getachievement++;
            }
            if (exercisecount >= 3)
            {
                if (AddAchievement(DefaultAchievements[1].title))
                    getachievement++;
            }
            if (exercisecount >= 5)
            {
                if (AddAchievement(DefaultAchievements[2].title))
                    getachievement++;
            }
            if (exercisecount >= 10)
            {
                if (AddAchievement(DefaultAchievements[3].title))
                    getachievement++;
            }
            if (getachievement > 1)
            {
                MessageBox.Show("Congratulations! You got " + getachievement + " achievements!", "Achievement");
            }
            else if (getachievement > 0)
            {
                MessageBox.Show("Congratulations! You got an achievement!", "Achievement");
            }
            return getachievement;
        }

        public static bool AddExerciseCount()
        {
            if (user == null) return false;
            SqlCommand command = new SqlCommand("select * from [Exercise] where userid = @userid and date = @date", conn);
            command.Parameters.AddWithValue("@userid", user.id);
            command.Parameters.AddWithValue("@date", DateTime.Today);
            int count = 0;
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    count = Convert.ToInt32(reader[3]);
                    count++;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Connection to database failed");
                return false;
            }
            if (count != 0)
            {
                SqlCommand command2 = new SqlCommand("update [exercise] set count = @count where userid = @userid and date = @date", conn);
                command2.Parameters.AddWithValue("@count", count);
                command2.Parameters.AddWithValue("@userid", user.id);
                command2.Parameters.AddWithValue("@date", DateTime.Today.ToShortDateString());
                try
                {
                    conn.Open();
                    command2.ExecuteNonQuery();
                    conn.Close();
                    //MessageBox.Show("Update exercise count succeed !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Add exercise count failed");
                    return false;
                }
            }
            else
            {
                SqlCommand command2 = new SqlCommand("insert into [exercise] (userid,date,count) values (@userid,@date,1)", conn);
                command2.Parameters.AddWithValue("@userid", user.id);
                command2.Parameters.AddWithValue("@date", DateTime.Today.Date.ToShortDateString());
                command2.CommandType = System.Data.CommandType.Text;
                try
                {
                    conn.Open();
                    command2.ExecuteNonQuery();
                    conn.Close();
                    //MessageBox.Show("Add exercise count succeed !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Insert exercise count failed");
                    return false;
                }
            }
            return true;
        }

        public static bool SetUserDetails(string username, string password)
        {
            SqlCommand command = new SqlCommand("select * from dbo.[user] where username = @username and password = @password", conn);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            string[] userval = new string[8];
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    for (int i = 0; i < 8; i++)
                    {
                        userval[i] = reader[i].ToString();
                    }
                    reader.Close();
                    conn.Close();
                    user = new User(Convert.ToInt32(userval[0]), userval[1], userval[2], userval[3], Convert.ToInt32(userval[4]), Convert.ToInt32(userval[5]), userval[6], Convert.ToChar(userval[7]));
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Connection to database failed");
            }
            conn.Close();
            return false;
            
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static bool AddAchievement(string title)
        {
            Achievement target = null;
            if (user.id < 0) return false;
            foreach (Achievement a in DefaultAchievements)
            {
                if (title == a.title)
                {
                    target = a;
                    break;
                }
            }
            if (!CheckAchievement(title) && target != null)
            {
                byte[] imagedata = ImageToByte(target.image);
                SqlCommand command = new SqlCommand("insert into [achievement] (userid,title,descc,howtoget,image) values (@userid,@title,@descc,@howtoget,@pic)", conn);
                command.Parameters.AddWithValue("@userid", user.id);
                command.Parameters.AddWithValue("@title", target.title);
                command.Parameters.AddWithValue("@descc", target.desc);
                command.Parameters.AddWithValue("@howtoget", target.howtoget);
                command.Parameters.AddWithValue("@pic", (object)imagedata);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    //MessageBox.Show("Add Achievement succeed !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Insert achievement failed");
                    return false;
                }
                Achievements.Add(new Achievement(target.title, target.desc, target.howtoget, target.image));
                return true;
            }
            return false;
        }

        public static bool CheckAchievement(string title)
        {
            SqlCommand command = new SqlCommand("select * from [achievement] where title = @title and userid = @userid", conn);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@userid", user.id);
            try
            {
                conn.Open();
                if (command.ExecuteScalar() == null)
                {
                    conn.Close();
                    return false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public static async void WaitSomeTime(int time)
        {
            await Task.Delay(time);
        }

        public static bool GetAchievements()
        {
            if (user.id < 0) return false;
            SqlCommand command = new SqlCommand("select * from dbo.[achievement] where userid = @userid", conn);
            command.Parameters.AddWithValue("@userid", user.id);
            object[] userval = new object[6];
            try
            {
                conn.Open();
                Achievements.Clear();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < 6; i++)
                    {
                        userval[i] = reader[i];
                    }
                    Achievements.Add(new Achievement(Convert.ToInt32(userval[0]), Convert.ToInt32(userval[1]), userval[2].ToString(), userval[3].ToString(), userval[4].ToString(), byteArrayToImage((byte[])userval[5])));
                }
                reader.Close();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Connection to database failed" + ex.ToString());
            }
            conn.Close();
            return false;
        }

        //public static async void WaitSomeTime(int time)
        //{
        //    await Task.Delay(time);
        //}
    }
}

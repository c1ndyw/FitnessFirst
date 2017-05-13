using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class Global
    {
        private static string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=E:\\SoftwaresFiles\\VisualStudio\\FITNESS_FIRST\\FITNESS_FIRST\\Fitnessfirst.mdf";
        private static SqlConnection conn = new SqlConnection(connString);
        public static int ButtonSize = 100;
        public static List<string> Sports = new List<string>();
        public static List<string> Achievements = new List<string>();

        public static void DefaultSport()
        {
            Sports = new List<string>();
            Sports.Add("Push Up");
            Sports.Add("Jogging");
            Sports.Add("Yoga");
            Sports.Add("Aerobic");
            Sports.Add("Sit Up");
            Sports.Add("Abs");
            Sports.Add("Crunch");
        }

        public static void DefaultAchievments()
        {
            Achievements = new List<string>();
            Achievements.Add("Push Up");
            Achievements.Add("Jogging");
            Achievements.Add("Yoga");
            Achievements.Add("Aerobic");
            Achievements.Add("Sit Up");
            Achievements.Add("Abs");
            Achievements.Add("Crunch");
        }

        public static void AddSport(string sport)
        {
            Sports.Add(sport);
        }

        public static void RemoveSport(string sport)
        {
            Sports.Remove(sport);
        }

        public static bool CheckUser(string username)
        {
            SqlCommand command = new SqlCommand("select * from [user] where name = @name", conn);
            command.Parameters.AddWithValue("@name", username);
            try
            {
                conn.Open();
                command.ExecuteScalar();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public static string[] GetUserDetails(string username)
        {
            SqlCommand command = new SqlCommand("select * from [user] where name = @name", conn);
            command.Parameters.AddWithValue("@name", username);
            string[] userval = new string[5];
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                for (int i = 0; i < 5; i++)
                {
                    userval[i] = reader[i].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return userval;
        }

        public static async void WaitSomeTime(int time)
        {
            await Task.Delay(time);
        }
    }
}

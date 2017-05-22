using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessFirst;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AchievementUnitTest
{
    [TestClass]
    public class AchievementUnitTest
    {

        [TestMethod]
        public void TestDefaultAchievement()
        {
            Global.SetDefaultAchievements();
            Assert.AreEqual(Global.DefaultAchievements[0].title, "First Exercise");
        }

        [TestMethod]
        public void TestInActiveMode()
        {
            Global.SetDefaultAchievements();
            Global.user = new User(11, "Duong", "duong", "duong", 0, 0, "duong@duong.com", 'M');
            AchievementPage achievementpage = new AchievementPage();
            achievementpage.SetButtons();
            Assert.AreEqual(achievementpage.AchievementBox[1].Title().Text, "???");
        }

        [TestMethod]
        public void TestActiveMode()
        {
            int getachievement = 0;
            Global.user = new User(10, "Duong", "duong", "duong", 0, 0, "duong@duong.com", 'M');
            Global.AddAchievement("First Exercise");
            getachievement = Global.SynchronizeAchievement();
            Assert.AreEqual(getachievement, 0);
        }


        [TestMethod]
        public void TestGetCount()
        {
            SqlCommand command = new SqlCommand("select count from [Exercise] where userid = @userid and id = 5", Global.conn);
            command.Parameters.AddWithValue("@userid", 1);
            int count = 0;
            try
            {
                Global.conn.Open();
                count = Convert.ToInt32(command.ExecuteScalar());
                Global.conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.ToString());
            }
            Assert.AreEqual(count, 2);
        }


        [TestMethod]
        public void TestAddCount()
        {
            SqlCommand command = new SqlCommand("insert into [exercise] (userid,date,count) values (@userid,@date,1)", Global.conn);
            command.Parameters.AddWithValue("@userid", 1);
            command.Parameters.AddWithValue("@date", DateTime.Today.Date.ToShortDateString());
            bool succeed = false;
            try
            {
                Global.conn.Open();
                Convert.ToInt32(command.ExecuteNonQuery());
                Global.conn.Close();
                succeed = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.ToString());
            }
            Assert.AreEqual(succeed, true);
        }
    }
}

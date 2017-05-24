using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessFirst;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FoodUnitTest
{
    [TestClass]
    public class FoodUnitTest
    {
        [TestMethod]
        public void TestInitializeTitle()
        {
            FoodPage foodPage = new FoodPage();
            try
            {
                foodPage.Title.Text = "Food Suggestions";
                foodPage.Title.Font = Global.TitleFont2;
                foodPage.Title.BackColor = Color.Transparent;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.AreEqual(foodPage.Title.Text, "Food Suggestions");
            Assert.AreEqual(foodPage.Title.Font, Global.TitleFont2);
            Assert.AreEqual(foodPage.Title.BackColor, Color.Transparent);
        }

        [TestMethod]
        public void TestInitializeDesc()
        {
            FoodPage foodPage = new FoodPage();
            try
            {
                foodPage.Desc.Text = "List of foods";
                foodPage.Desc.Font = Global.CustomFont;
                foodPage.Desc.BackColor = Color.Transparent;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.AreEqual(foodPage.Desc.Text, "List of foods");
            Assert.AreEqual(foodPage.Desc.Font, Global.CustomFont);
            Assert.AreEqual(foodPage.Desc.BackColor, Color.Transparent);
        }

        [TestMethod]
        public void TestDefaultFood()
        {
            List<Food> foods = new List<Food>();
            try
            {
                foods.Add(new Food("Banana", "Eating a medium banana with ½ cup of\nGreek yogurt before do exercise 30 minutes\nwould aids in maintaining nerve and muscle\nfunction.", "", null));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.AreEqual(foods[0].title, "Banana");
            Assert.AreEqual(foods[0].desc, "Eating a medium banana with ½ cup of\nGreek yogurt before do exercise 30 minutes\nwould aids in maintaining nerve and muscle\nfunction.");
        }

        [TestMethod]
        public void TestInitializeFoodPage()
        {
            FoodPage foodPage = new FoodPage();
            try
            {
                Global.SetDefaultFoods();
                foodPage.InitializeTitle();
                foodPage.InitializeDesc();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.AreEqual(foodPage.Title.Text, "Food Suggestions");
            Assert.AreEqual(foodPage.Desc.Text, "List of foods");
            Assert.AreEqual(foodPage.BackColor, Color.White);
            Assert.AreEqual(Global.DefaultFoods[0].title, "Banana");
        }

        [TestMethod]
        public void TestFoodMenuBarCorrect()
        {
            MainPage MainPage = new MainPage();
            Results result = Results.Failed;
            Pages page = Pages.FoodPage;
            try
            {
                switch (page)
                {
                    case Pages.HomePage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._homePage);
                        break;
                    case Pages.CalendarPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._calendarPage);
                        break;
                    case Pages.SummaryPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._graphPage);
                        break;
                    case Pages.SettingsPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._settingsPage);
                        break;
                    case Pages.AchievementPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._achievementPage);
                        break;
                    case Pages.FoodPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._foodPage);
                        result = Results.Success;
                        break;
                    default:
                        result = Results.Failed;
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.AreEqual(result, Results.Success);
        }

        [TestMethod]
        public void TestFoodMenuBarIncorrect()
        {
            MainPage MainPage = new MainPage();
            Results result = Results.Failed;
            Pages page = Pages.HomePage;
            try
            {
                switch (page)
                {
                    case Pages.HomePage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._homePage);
                        break;
                    case Pages.CalendarPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._calendarPage);
                        break;
                    case Pages.SummaryPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._graphPage);
                        break;
                    case Pages.SettingsPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._settingsPage);
                        break;
                    case Pages.AchievementPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._achievementPage);
                        break;
                    case Pages.FoodPage:
                        MainPage.Controls.RemoveAt(1);
                        MainPage.Controls.Add(MainPage._foodPage);
                        result = Results.Success;
                        break;
                    default:
                        result = Results.Failed;
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.AreEqual(result, Results.Failed);
        }

        [TestMethod]
        public void TestResizeFoodPage()
        {
            FoodPage foodPage = new FoodPage();
            Panel foodContainer = new Panel();
            try
            {
                foodContainer.Location = new Point(100, 100);
                foodPage.Title.Location = new Point(foodContainer.Location.X, 20);
                foodPage.Desc.Location = new Point(foodContainer.Location.X, 55);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.AreEqual(foodPage.Title.Location, new Size(100, 20));
            Assert.AreEqual(foodPage.Desc.Location, new Size(100, 55));
        }

        [TestMethod]
        public void TestSetTexts()
        {
            FoodPage foodPage = new FoodPage();
            try
            {
                foodPage.InitializeTitle();
                foodPage.InitializeDesc();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.AreEqual(foodPage.Title.Text, "Food Suggestions");
            Assert.AreEqual(foodPage.Desc.Text, "List of foods");
        }

        [TestMethod]
        public void TestSetFoodBox()
        {
            FoodBox _foodBtn = new FoodBox();
            Panel foodContainer = new Panel();
            Results result = Results.Failed;
            try
            {
                foodContainer.Width = 500;
                int buttonSize = (int)(foodContainer.Width / 5);
                _foodBtn.Name = "food1";
                _foodBtn.Location = new Point(0, 0);
                _foodBtn.Width = buttonSize - 2;
                _foodBtn.Height = buttonSize - 2;
                _foodBtn.BackColor = Color.Transparent;
                _foodBtn.Visible = true;
                _foodBtn.Picture.Location = new Point(5, 5);
                _foodBtn.Picture.Width = _foodBtn.Width - 10;
                _foodBtn.Picture.Height = _foodBtn.Height - 90;
                _foodBtn.Picture.BackgroundImage = null;
                _foodBtn.Picture.BackgroundImageLayout = ImageLayout.Zoom;
                _foodBtn.Picture.Cursor = Cursors.Hand;
                _foodBtn.Title.Text = "title";
                _foodBtn.Title.Location = new Point(5, _foodBtn.Picture.Height + 10);
                _foodBtn.Title.Width = _foodBtn.Width - 5;
                _foodBtn.Title.Height = 30;
                _foodBtn.Title.Font = new System.Drawing.Font("Arial", 14);
                _foodBtn.Title.TextAlign = ContentAlignment.MiddleCenter;
                _foodBtn.Title.ForeColor = Color.DarkRed;
                _foodBtn.Desc.Text = "desc";
                _foodBtn.Desc.Location = new Point(5, _foodBtn.Picture.Height + 40);
                _foodBtn.Desc.Width = _foodBtn.Width;
                _foodBtn.Desc.Height = 50;
                _foodBtn.Desc.Font = new System.Drawing.Font("Arial", 14);
                _foodBtn.Desc.TextAlign = ContentAlignment.MiddleCenter;
                _foodBtn.Desc.ForeColor = Color.IndianRed;
                result = Results.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result = Results.Failed;
            }
            Assert.AreEqual(_foodBtn.Name, "food1");
            Assert.AreEqual(_foodBtn.Title, "title");
            Assert.AreEqual(_foodBtn.Desc, "desc");
            Assert.AreEqual(result, Results.Success);
        }

        [TestMethod]
        public void TestSetFoods()
        {
            Global.SetDefaultFoods();
            FoodPage foodPage = new FoodPage();
            List<FoodBox> _foodBtn = new List<FoodBox>();
            Panel foodContainer = new Panel();
            Results result = Results.Failed;
            try
            {
                foodContainer.Width = 500;
                int buttonSize = (int)(foodContainer.Width / 5);
                int row = 0, col = 0;
                for (int i = 0; i < Global.DefaultFoods.Count; i++)
                {
                    _foodBtn.Add(new FoodBox());
                    _foodBtn[i].Name = Global.DefaultFoods[i].title;
                    _foodBtn[i].Location = new Point(col * buttonSize + 1 + foodContainer.Width / 2 - buttonSize * 2, row * buttonSize + 1);
                    _foodBtn[i].Width = buttonSize - 2;
                    _foodBtn[i].Height = buttonSize - 2;
                    _foodBtn[i].BackColor = Color.Transparent;
                    _foodBtn[i].Visible = true;
                    _foodBtn[i].Picture.Location = new Point(5, 5);
                    _foodBtn[i].Picture.Width = _foodBtn[i].Width - 10;
                    _foodBtn[i].Picture.Height = _foodBtn[i].Height - 90;
                    _foodBtn[i].Picture.BackgroundImage = null;
                    _foodBtn[i].Picture.BackgroundImageLayout = ImageLayout.Zoom;
                    _foodBtn[i].Picture.Cursor = Cursors.Hand;
                    _foodBtn[i].Title.Text = Global.DefaultFoods[i].title;
                    _foodBtn[i].Title.Location = new Point(5, _foodBtn[i].Picture.Height + 10);
                    _foodBtn[i].Title.Width = _foodBtn[i].Width - 5;
                    _foodBtn[i].Title.Height = 30;
                    _foodBtn[i].Title.Font = new System.Drawing.Font("Arial", 14);
                    _foodBtn[i].Title.TextAlign = ContentAlignment.MiddleCenter;
                    _foodBtn[i].Title.ForeColor = Color.DarkRed;
                    _foodBtn[i].Desc.Text = Global.DefaultFoods[i].desc;
                    _foodBtn[i].Desc.Location = new Point(5, _foodBtn[i].Picture.Height + 40);
                    _foodBtn[i].Desc.Width = _foodBtn[i].Width;
                    _foodBtn[i].Desc.Height = 50;
                    _foodBtn[i].Desc.Font = new System.Drawing.Font("Arial", 14);
                    _foodBtn[i].Desc.TextAlign = ContentAlignment.MiddleCenter;
                    _foodBtn[i].Desc.ForeColor = Color.IndianRed;
                    col++;
                    if (col >= 4)
                    {
                        col = 0;
                        row++;
                    }
                    foodContainer.Controls.Add(_foodBtn[i]);
                    result = Results.Success;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result = Results.Failed;
            }
            Assert.AreEqual(_foodBtn[0].Name, Global.DefaultFoods[0].title);
            Assert.AreEqual(result, Results.Success);
        }
    }
}

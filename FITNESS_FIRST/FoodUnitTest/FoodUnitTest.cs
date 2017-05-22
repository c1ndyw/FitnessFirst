using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessFirst;
using System.Drawing;

namespace FoodUnitTest
{
    [TestClass]
    public class FoodUnitTest
    {
        [TestMethod]
        public void TestFoodMenuBar()
        {
            Window w = new Window();
            Global.Window = w;
            Results result = Global.ChangePage(Pages.FoodPage);
            Assert.AreEqual(result, Results.Success);
        }

        [TestMethod]
        public void TestResizeFoodPage()
        {
            FoodPage foodPage = new FoodPage();
            foodPage.ReSize();
            Assert.AreEqual(foodPage.Title.Location, new Size(100, 20));
            Assert.AreEqual(foodPage.Desc.Location, new Size(100, 55));
        }

        [TestMethod]
        public void TestInitializeTexts()
        {
            FoodPage foodPage = new FoodPage();
            foodPage.InitializeTitle();
            foodPage.InitializeDesc();
            Assert.AreEqual(foodPage.Title.Text, "Food Suggestions");
            Assert.AreEqual(foodPage.Desc.Text, "List of foods");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessFirst;
using System.Drawing;
using System.Windows.Forms;

namespace FoodUnitTest
{
    [TestClass]
    public class FoodBoxUnitTest
    {
        [TestMethod]
        public void TestFoodBoxInit()
        {
            FoodBox foodBox = new FoodBox();
            foodBox.Initialize();
            Assert.AreEqual(foodBox.FormBorderStyle, FormBorderStyle.None);
            Assert.AreEqual(foodBox.BackColor, Color.White);
        }

        [TestMethod]
        public void TestResizeFoodBox()
        {
            FoodBox foodBox = new FoodBox();
            foodBox.ReSize();
            Assert.AreEqual(foodBox.Size, new Size(620, 300));
            Assert.AreEqual(foodBox.StartPosition, FormStartPosition.CenterScreen);
        }

        [TestMethod]
        public void TestFoodBoxSetUp()
        {
            FoodBox foodBox = new FoodBox();
            foodBox.SetText("title","desc",null);
            Assert.AreEqual(foodBox.Title.Text, "title");
            Assert.AreEqual(foodBox.Desc.Text, "desc");
        }
    }
}

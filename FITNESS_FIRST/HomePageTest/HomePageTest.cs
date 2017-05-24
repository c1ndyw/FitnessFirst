using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Drawing;
using FitnessFirst;

namespace HomePageTest
{
    [TestClass]
    public class HomePageTest
    {
        [TestMethod]
        public void TestHomeMenuBar()
        {
            Window w = new Window();
            Global.Window = w;
            Results result = Global.ChangePage(Pages.HomePage);
            Assert.AreEqual(result, Results.Success);
        }

        [TestMethod]
        public void TestHomeInitialization()
        {
        }

        [TestMethod]
        public void TestHomeInitializationTitle()
        {
        }

        [TestMethod]
        public void TestHomeResize()
        {
        }
    }
}

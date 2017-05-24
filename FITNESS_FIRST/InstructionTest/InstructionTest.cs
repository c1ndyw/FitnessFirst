using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessFirst;
using System.Windows.Forms;
using System.Drawing;

namespace InstructionTest
{
    [TestClass]
    public class InstructionTest
    {
        [TestMethod]
        public void TestHelpInit()
        {
            FitnessFirst.Help help = new FitnessFirst.Help();
            help.Initialize();
            Assert.AreEqual(help.FormBorderStyle, FormBorderStyle.None);
            Assert.AreEqual(help.BackColor, Color.White);
        }

        [TestMethod]
        public void TestResizeHelp()
        {
            FitnessFirst.Help help = new FitnessFirst.Help();
            help.ReSize();
            Assert.AreEqual(help.Size, new Size(620, 300));
            Assert.AreEqual(help.StartPosition, FormStartPosition.CenterScreen);
        }

        [TestMethod]
        public void TestHelpSetUp()
        {
            FitnessFirst.Help help = new FitnessFirst.Help();
            help.SetText("title", "desc");
            Assert.AreEqual(help.Title.Text, "title");
            Assert.AreEqual(help.Desc.Text, "desc");
        }
    }
}

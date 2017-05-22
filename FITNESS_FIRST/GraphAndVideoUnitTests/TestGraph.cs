using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessFirst;

namespace GraphAndVideoUnitTests
{
  
        [TestClass]
        public class TestGraph
        {
            [TestMethod]
            public void TestInitColor()
            {
                GraphPage graph = new GraphPage();
                graph.Initialization();
                Assert.AreEqual(graph.BackColor, Color.White);
            }

            [TestMethod]
            public void TestLocation()
            {
                GraphPage graph = new GraphPage();
                graph.setLocation();
                Assert.AreEqual(graph.Chart.Location, new Point(100, 100));
            }

            [TestMethod]
            public void TestResize()
            {
                GraphPage graph = new GraphPage();
                graph.setSize();

                Assert.AreEqual(graph.Chart.Size, new Size(graph.Width - 100 * 2, graph.Height - 100 * 2));
            }
        
    }
}

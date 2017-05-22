using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessFirst;
using System.Windows.Forms;

namespace GraphAndVideoUnitTests
{
    [TestClass]
    public class TestVideo
    {
        /// <summary>
        /// Test 1
        /// Test the start clock button should show at the beginning
        /// </summary>
        [TestMethod]
        public void Test1_The_Start_Clock_Shows_At_The_Beginning()
        {
            ExercisePage page = new ExercisePage();
            bool expect = true;
            bool actual = page.IsStrClkShow;
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// Test 2
        /// Test the pause clock button should hide at the beginning
        /// </summary>
        [TestMethod]
        public void Test2_The_Pause_Clock_Hides_At_The_Beginning()
        {
            ExercisePage page = new ExercisePage();
            bool expect = false;
            bool actual = page.ISPauClkShow;
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// Test 3
        /// Test the video should play when it starts
        /// </summary>
        [TestMethod]
        public void Test3_The_Video_Is_Played_When_Starting()
        {
            ExercisePage page = new ExercisePage();
            page.Start();
            string expect = "start";
            string actual = page.State;
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// Test 4
        /// Test the start clock button should hide when the video is playing
        /// </summary>
        [TestMethod]
        public void Test4_The_Start_Clock_Hides_When_Playing()
        {
            ExercisePage page = new ExercisePage();
            page.Start();
            bool expect = false;
            bool actual = page.IsStrClkShow;
            Assert.AreEqual(expect, actual);
        }
        /// <summary>
        /// Test 5
        /// Test the pause clock button shoud show when the video is playing
        /// </summary>
        [TestMethod]
        public void Test5_The_Pause_Clock_Hides_When_Playing()
        {
            ExercisePage page = new ExercisePage();
            page.Pause();
            bool expect = false;
            bool actual = page.ISPauClkShow;
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// Test 6
        /// Test the video state  will be paused when the user clicks pause button
        /// </summary>
        [TestMethod]
        public void Test6_Pause_0f_Video()
        {
            ExercisePage page = new ExercisePage();

            page.Pause();
            string expect = "pause";
            string actual = page.State;
            Assert.AreEqual(expect, actual);
        }


        /// <summary>
        /// Test 7
        /// Test the start clock button should show when pausing
        /// </summary>
        [TestMethod]
        public void Test7_The_Start_Clock_Shows_When_Pausing()
        {
            ExercisePage page = new ExercisePage();
            page.Pause();
            bool expect = true;
            bool actual = page.IsStrClkShow;
            Assert.AreEqual(expect, actual);
        }


        /// <summary>
        /// Test 8
        /// Test the pause clock button should hide when pausing
        /// </summary>
        [TestMethod]
        public void Test8_The_Pause_Clock_Hides_When_Pausing()
        {
            ExercisePage page = new ExercisePage();
            page.Pause();
            bool expect = false;
            bool actual = page.ISPauClkShow;
            Assert.AreEqual(expect, actual);
        }
        

        /// <summary>
        /// Test 9
        /// Test while in the pause state, the exercises' duration should be also pause and 
        /// only continue to run if the user unpause the video
        /// </summary>
        [TestMethod]
        public void Test9_Pause_0f_Video_Animation()
        {
            ExercisePage page = new ExercisePage();
            page.Timer = 3;
            page.TestStartandPause();
            int expect = 2;
            int actual = page.Timer;
            Assert.AreEqual(expect, actual);
        }



        /// <summary>
        /// Test 10
        /// Test after the exercise’s duration is finished, the video should be stopped 
        /// playing
        /// </summary>
        [TestMethod]
        public void Test10_Stop_Of_Video()
        {
            ExercisePage page = new ExercisePage();

            page.Timer = 0;
            page.TestTimerTick();
            string expect = "stop";
            string actual = page.State;

            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// Test 11
        /// Test the Clock should reset after the video finished
        /// </summary>
        [TestMethod]
        public void Test11_Whether_Clock_Is_Reseted()
        {
            ExercisePage page = new ExercisePage();
            page.Timer = -1;
            page.TestTimerTick();
            int expect = 10;
            int actual = page.Timer;
            Assert.AreEqual(expect, actual);
        }


        /// <summary>
        /// Test 12
        /// Test the start clock button should shows after reseting
        /// </summary>
        [TestMethod]
        public void Test12_The_Start_Clock_Shows_After_Reset()
        {
            ExercisePage page = new ExercisePage();
            page.Timer = -1;
            page.TestTimerTick();
            bool expect = true;
            bool actual = page.IsStrClkShow;
            Assert.AreEqual(expect, actual);
        }


        /// <summary>
        /// Test 13
        /// Test the pause clock buton should hide after reseting
        /// </summary>
        [TestMethod]
        public void Test13_The_Pause_Clock_Hides_After_Reset()
        {
            ExercisePage page = new ExercisePage();
            page.Timer = -1;
            page.TestTimerTick();
            bool expect = false;
            bool actual = page.ISPauClkShow;
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// Test 14
        /// Test the video should be played correctly associated with the icon
        /// </summary>
        [TestMethod]
        public void Test14_The_Correction_Of_Video()
        {
            ExercisePage page = new ExercisePage();
            Sports expect = Sports.JumpingJacks;
            Sports actual = page.ExerciseName;
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// Test 15
        /// Test the size of the start and pause clock button
        /// </summary>
        [TestMethod]
        public void Test15_Width_Of_Start_Clock_And_Pause_Clock()
        {
            ExercisePage page = new ExercisePage();

            int expect = page.PauseClock.Width;
            int actual = page.StartClock.Width;
            Assert.AreEqual(expect, actual);
        }
        /// <summary>
        /// Test 16
        /// Test the height of the start and pause clock button
        /// </summary>
        [TestMethod]
        public void Test16_Height_Of_Start_Clock_And_Pause_Clock()
        {
            ExercisePage page = new ExercisePage();

            int expect = page.PauseClock.Height;
            int actual = page.StartClock.Height;
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// Test 17
        /// Test the location of the start and pause clock button
        /// </summary>
        [TestMethod]
        public void Test17_Location_Of_Start_Clock_And_Pause_Clock()
        {
            ExercisePage page = new ExercisePage();

            Point expect = page.PauseClock.Location;
            Point actual = page.StartClock.Location;
            Assert.AreEqual(expect, actual);
        }
        /// <summary>
        /// Test 18
        /// Test the cursor when hovering start clock button
        /// </summary>
        [TestMethod]
        public void Test18_Cursor_When_Hovering_Start_Clock()
        {
            ExercisePage page = new ExercisePage();
            page.ReSize();
            Cursor expect = Cursors.Hand;
            Cursor actual = page.StartClock.Cursor;
            Assert.AreSame(expect, actual);
        }

        /// <summary>
        /// Test 19
        /// Test the cursor when hovering pause clock button
        /// </summary>
        [TestMethod]
        public void Test19_Cursor_When_Hovering_Pause_Clock()
        {
            ExercisePage page = new ExercisePage();
            page.ReSize();
            Cursor expect = Cursors.Hand;
            Cursor actual = page.PauseClock.Cursor;
            Assert.AreSame(expect, actual);
        }
    }
   
}

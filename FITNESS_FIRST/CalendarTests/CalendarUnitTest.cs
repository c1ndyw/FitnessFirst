using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar.NET;
using FitnessFirst;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class CalendarUnitTest
    {
        [TestMethod]
        public void ResizeTest()
        {
            CalendarPage cp = new CalendarPage();
            cp.ReSize();
            Assert.AreEqual(cp.Calendar.Location, new Point(10, 10));
            Assert.AreEqual(cp.Calendar.Size, new Size(cp.Width - 20, cp.Height - 50));
        }

        [TestMethod]
        public void CalendarInitTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            Assert.AreEqual(c.CalendarView, CalendarViews.Month);
        }

        [TestMethod]
        public void AddEventTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            c.GetEvents().Clear();
            var exerciseEvent = new CustomEvent
            {
                Date = DateTime.Now,
                RecurringFrequency = RecurringFrequencies.Monthly,
                EventLengthInHours = 1,
                EventText = "event1",
                EventFont = new Font(FontFamily.GenericSansSerif, 12.0f, FontStyle.Regular)
            };
            c.AddEvent(exerciseEvent);
            Assert.AreEqual(c.GetEvents().Count, 1);
        }

        [TestMethod]
        public void RemoveEventTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            c.GetEvents().Clear();
            var exerciseEvent = new CustomEvent
            {
                Date = DateTime.Now,
                RecurringFrequency = RecurringFrequencies.Monthly,
                EventLengthInHours = 1,
                EventText = "event1",
                EventFont = new Font(FontFamily.GenericSansSerif, 12.0f, FontStyle.Regular)
            };
            c.AddEvent(exerciseEvent);
            c.RemoveEvent(exerciseEvent);
            Assert.AreEqual(c.GetEvents().Count, 0);
        }

        [TestMethod]
        public void PresetHolidaysTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            c.GetEvents().Clear();
            c.PresetHolidays();
            List<IEvent> events = c.GetEvents();
            Assert.AreEqual(events[0].EventText, "April Fools Day");
        }

        [TestMethod]
        public void LastDayOfWeekInMonthTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            DateTime d = new DateTime(2017, 5, 1); //1st May 2017
            Assert.AreEqual(c.LastDayOfWeekInMonth(d, d.DayOfWeek), DateTime.Parse("5/29/2017 12:00:00 AM"));
        }

        [TestMethod]
        public void MaxTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            int i = c.Max(30,31,33,32) + 5;
            Assert.AreEqual(i, 38);
        }

        [TestMethod]
        public void DayForwardTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            c.GetEvents().Clear();
            var exerciseEvent = new CustomEvent
            {
                Date = DateTime.Now,
                RecurringFrequency = RecurringFrequencies.Monthly,
                EventLengthInHours = 1,
                EventText = "event1",
                EventFont = new Font(FontFamily.GenericSansSerif, 12.0f, FontStyle.Regular)
            };
            c.AddEvent(exerciseEvent);
            bool recurring = c.DayForward(exerciseEvent, DateTime.Now);
            Assert.IsTrue(recurring);
        }

        [TestMethod]
        public void GetFinalBackColorTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            c.BackColor = Color.White;
            c.GetFinalBackColor();
            Assert.AreEqual(c.BackColor, Color.White);
        }

        [TestMethod]
        public void NumberOfWeeksTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            int weeks = c.NumberOfWeeks(2017, 5);
            Assert.AreEqual(weeks, 5);
        }

        [TestMethod]
        public void GetEventsTest()
        {
            Calendar.NET.Calendar c = new Calendar.NET.Calendar();
            c.GetEvents().Clear();
            var exerciseEvent = new CustomEvent
            {
                Date = DateTime.Now,
                RecurringFrequency = RecurringFrequencies.Monthly,
                EventLengthInHours = 1,
                EventText = "event1",
                EventFont = new Font(FontFamily.GenericSansSerif, 12.0f, FontStyle.Regular)
            };
            c.AddEvent(exerciseEvent);
            Assert.AreEqual(c.GetEvents()[0].EventText, "event1");
        }
    }
}

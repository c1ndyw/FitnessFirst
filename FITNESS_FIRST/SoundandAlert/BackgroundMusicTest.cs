using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Media;
using FitnessFirst;
using System.Windows.Forms;
using System.Collections.Generic;
using Calendar.NET;

namespace Sound_and_Alert
{
    [TestClass]
    public class BackgroundMusicTest
    {
        MainMenuHeader m = new MainMenuHeader();
        Window w = new Window();
        CalendarPage p = new CalendarPage();

        public bool state = true;

        [TestMethod]
        public void testPlay()
        {


            bool played = false;
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(Sound_and_Alert.Properties.Resources.background);
                simpleSound.Play();
                played = true;
            }
            catch (Exception e)
            {
            }
            Assert.IsTrue(played);
        }

        [TestMethod]
        public void SoundEnabled()
        {
            
            w.play = true;
            bool play = w.PlyMusic();
            Assert.AreEqual(true,play);

           
        }

        [TestMethod]
        public void SoundDefault()
        {
            
            Assert.AreEqual(true,w.play);

        }

        [TestMethod]
        public void Mute() {
           
            w.play = false;
            bool result;
            result = w.PlyMusic();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void AlertOn()
        {
            Timer timerAlert = new Timer();
            List<IEvent> events = new List<IEvent>();
            var exerciseEvent = new CustomEvent
            {
                StartDate = Convert.ToDateTime("5/5/2017 12:00:00 AM"),
                EndDate = Convert.ToDateTime("7/7/2017 12:00:00 AM"),
                RecurringFrequency = RecurringFrequencies.Daily,
                EventLengthInHours = 1,
                Alert = 1,
                EventText = "test",
                EventFont = Global.CustomFont,
                Days = new List<DayOfWeek>() { DayOfWeek.Thursday, DayOfWeek.Sunday }
            };
            events.Add(exerciseEvent);
             
              bool play = true;
              bool success = false;
                foreach (IEvent evt in events)
                {
                    if (DateTime.Today.Date.DayOfYear >= evt.StartDate.DayOfYear && DateTime.Today.Date.DayOfYear <= evt.EndDate.DayOfYear)
                    {
                        if (DateTime.Today.Year >= evt.StartDate.Year && DateTime.Today.Year <= evt.EndDate.Year)
                        {
                            if (evt.StartDate.ToShortTimeString() == "12:00 AM" && evt.Alert == 1)
                            {
                                foreach (DayOfWeek d in evt.Days)
                                {
                                    if (DayOfWeek.Thursday == d)
                                    {
                                        evt.Alert = 0;
                                        SoundPlayer s = new SoundPlayer(Properties.Resources.alert);
                                        if (play)
                                        {
                                            success = true;
                                            s.Play();
                                            if (MessageBox.Show("Your event: " + evt.EventText + " has been started !", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                                            {
                                                s.Stop();
                                            }
                                       }
                                        return;
                                    }
                                }
                            }
                        }
                    }
            }
            Assert.AreEqual(true, success);
        }

       
        public void PromptEvent()
        {
            List<IEvent> events = new List<IEvent>();
            CustomEvent exerciseEvent = new CustomEvent
            {
                StartDate = Convert.ToDateTime("5/5/2017"),
                EndDate = Convert.ToDateTime("7/7/2017"),
                RecurringFrequency = RecurringFrequencies.Daily,
                EventLengthInHours = 1,
                Alert = 1,
                EventText = "PushUp",
                EventFont = Global.CustomFont,
                Days = new List<DayOfWeek>()
            };
            events.Add(exerciseEvent);
            Assert.AreEqual(exerciseEvent.EventText, events[0].EventText);
        }

        [TestMethod]
        public void AlertOff()
        {
            Timer timerAlert = new Timer();
            List<IEvent> events = new List<IEvent>();
            var exerciseEvent = new CustomEvent
            {
                StartDate = Convert.ToDateTime("5/5/2017 12:00:00 AM"),
                EndDate = Convert.ToDateTime("7/7/2017 12:00:00 AM"),
                RecurringFrequency = RecurringFrequencies.Daily,
                EventLengthInHours = 1,
                Alert = 1,
                EventText = "test",
                EventFont = Global.CustomFont,
                Days = new List<DayOfWeek>() { DayOfWeek.Monday }
            };
            events.Add(exerciseEvent);

            bool play = false;
            bool success = true;
                foreach (IEvent evt in events)
                {
                    if (DateTime.Today.Date.DayOfYear >= evt.StartDate.DayOfYear && DateTime.Today.Date.DayOfYear <= evt.EndDate.DayOfYear)
                    {
                        if (DateTime.Today.Year >= evt.StartDate.Year && DateTime.Today.Year <= evt.EndDate.Year)
                        {
                            if (evt.StartDate.ToShortTimeString() == "12:00 AM" && evt.Alert == 1)
                            {
                                foreach (DayOfWeek d in evt.Days)
                                {
                                    if (DayOfWeek.Monday == d)
                                    {
                                        evt.Alert = 0;
                                        SoundPlayer s = new SoundPlayer(Properties.Resources.alert);
                                        if (play)
                                        {
                                            success = false;
                                            s.Play();
                                            if (MessageBox.Show("Your event: " + evt.EventText + " has been started !", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                                            {
                                                s.Stop();
                                            }
                                        }
                                        return;
                                    }
                                }
                            }
                        }
                    }
            }
            Assert.AreEqual(false, success);
        }


    }
}

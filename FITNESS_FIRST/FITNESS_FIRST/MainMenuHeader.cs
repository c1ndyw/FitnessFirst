using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.NET;
using System.Media;

namespace FitnessFirst
{
    public partial class MainMenuHeader : UserControl
    {
        Label time = new Label();
        private List<IEvent> events = new List<IEvent>();
        private int checkInterval = 5, count = 1;
        private bool alert = true;

        public MainMenuHeader()
        {
            InitializeComponent();
            initialization();
        }

        private void initialization()
        {
            BackColor = Color.FromArgb(255, 76, 76);
            logo.BackgroundImage = Properties.Resources.logo1;
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Location = new Point(30, 2);
            logo.Size = new System.Drawing.Size(96, 96);
            Title.Font = Global.TitleFont;
            Title.Text = "Fitness First";
            Title.ForeColor = Color.White;
            Title.Location = new Point(145, 30);
            homeBtn.Text = "";
            homeBtn.Name = "home";
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.BackgroundImage = FitnessFirst.Properties.Resources.home;
            homeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            calendarBtn.Text = "";
            calendarBtn.Name = "calendar";
            calendarBtn.Cursor = Cursors.Hand;
            calendarBtn.BackgroundImage = FitnessFirst.Properties.Resources.calendar;
            calendarBtn.BackgroundImageLayout = ImageLayout.Zoom;
            graphBtn.Text = "";
            graphBtn.Name = "graph";
            graphBtn.Cursor = Cursors.Hand;
            graphBtn.BackgroundImage = FitnessFirst.Properties.Resources.graph;
            graphBtn.BackgroundImageLayout = ImageLayout.Zoom;
            foodButton.Text = "";
            foodButton.Name = "food";
            foodButton.Cursor = Cursors.Hand;
            foodButton.BackgroundImage = FitnessFirst.Properties.Resources.musicon;
            musicbutton.Text = "";
            musicbutton.Name = "music";
            musicbutton.Cursor = Cursors.Hand;
            musicbutton.BackgroundImage = FitnessFirst.Properties.Resources.musicon;
            musicbutton.BackgroundImageLayout = ImageLayout.Zoom;
            alertBtn.Text = "";
            alertBtn.Name = "alert";
            alertBtn.Cursor = Cursors.Hand;
            alertBtn.BackgroundImage = FitnessFirst.Properties.Resources.alerton;
            alertBtn.BackgroundImageLayout = ImageLayout.Zoom;
            achievementBtn.Text = "";
            achievementBtn.Name = "achievements";
            achievementBtn.Cursor = Cursors.Hand;
            achievementBtn.BackgroundImage = FitnessFirst.Properties.Resources.achievement;
            achievementBtn.BackgroundImageLayout = ImageLayout.Zoom;
            logoutBtn.Text = "";
            logoutBtn.Name = "logout";
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.BackgroundImage = FitnessFirst.Properties.Resources.logout;
            logoutBtn.BackgroundImageLayout = ImageLayout.Zoom;
            time.ForeColor = Color.White;
            time.Font = Global.CustomFont;
            timer1.Interval = 1000;
            timer1.Start();
            Controls.Add(time);
        }

        public void ReSize()
        {
            Height = 100;
            Button[] _buttons = new Button[8];
            _buttons[0] = homeBtn;
            _buttons[1] = calendarBtn;
            //_buttons[3] = settingsBtn;
            _buttons[2] = foodButton;
            _buttons[3] = graphBtn;
            _buttons[4] = achievementBtn;
            _buttons[5] = musicButton;
            _buttons[6] = alertBtn;
            _buttons[7] = logoutBtn;
            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[_buttons.Length - i - 1].Location = new Point(this.Width - (i+1) * Global.ButtonSize - 40, 0);
                _buttons[_buttons.Length - i - 1].Width = Global.ButtonSize;
                _buttons[_buttons.Length - i - 1].Height = Global.ButtonSize;
                _buttons[_buttons.Length - i - 1].FlatStyle = FlatStyle.Flat;
                _buttons[_buttons.Length - i - 1].FlatAppearance.BorderSize = 0;
            }
            time.Location = new Point(this.Width / 2 - 140, 10);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Global.ChangePage(Pages.HomePage);
        }

        private void CalendarBtn_Click(object sender, EventArgs e)
        {
            Global.ChangePage(Pages.CalendarPage);
        }

        private void GraphBtn_Click(object sender, EventArgs e)
        {
            Global.ChangePage(Pages.SummaryPage);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Global.ChangePage(Pages.SettingsPage);
        }

        private void AchievementBtn_Click(object sender, EventArgs e)
        {
            Global.ChangePage(Pages.AchievementPage);
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            Global.ChangePage(Pages.HelpPage);
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            Global.ChangePage(Pages.FoodPage);
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            //muteBackground = !muteBackground;
            Window parent = (Window)Parent.Parent;
            parent.play = !parent.play;
            parent.PlyMusic();

            if (parent.play == true)
                musicbutton.BackgroundImage = FitnessFirst.Properties.Resources.musicon;
            else
                musicbutton.BackgroundImage = FitnessFirst.Properties.Resources.musicoff;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do you want to log out?", "Log Out", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Global.ChangePage(Pages.LoginPage);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss GMT");
            count--;
            if (count < 0)
            {
                foreach (IEvent evt in events)
                {
                    if (DateTime.Today.Date.DayOfYear >= evt.StartDate.DayOfYear && DateTime.Today.Date.DayOfYear <= evt.EndDate.DayOfYear)
                    {
                        if (DateTime.Today.Year >= evt.StartDate.Year && DateTime.Today.Year <= evt.EndDate.Year)
                        {
                            if (DateTime.Now.ToShortTimeString() == evt.StartDate.ToShortTimeString() && evt.Alert == 1)
                            {
                                foreach (DayOfWeek d in evt.Days)
                                {
                                    if (DateTime.Today.DayOfWeek == d)
                                    {
                                        evt.Alert = 0;
                                        SoundPlayer s = new SoundPlayer(Properties.Resources.alert);
                                        if (alert)
                                        {
                                            s.Play();
                                            if (MessageBox.Show("Your event: " + evt.EventText + " has been started !", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                                            {
                                                s.Stop();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                count = checkInterval;
            }
        }

        public void RecallEvents()
        {
            MainPage parent = (MainPage)Parent;
            events = parent.getEvents();
            string eventstext = "Your event for today: ";
            foreach (IEvent evt in events)
            {
                if (DateTime.Now >= evt.StartDate && DateTime.Now <= evt.EndDate)
                {
                    foreach (DayOfWeek d in evt.Days)
                    {
                        if (DateTime.Today.DayOfWeek == d)
                        {
                            eventstext += "\nEvent: " + evt.EventText + ", Time: " + evt.StartDate.ToShortTimeString();
                            break;
                        }
                    }
                }
            }
            if (eventstext != "Your event for today: ")
                MessageBox.Show(eventstext, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(eventstext + "nothing", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public Button alertButton
        {
            get { return musicbutton; }
        }

        public Button musicButton
        {
            get { return musicbutton; }
        }

        private void alertButton_Click(object sender, EventArgs e)
        {
            alert = !alert;
            if (alert)
                alertBtn.BackgroundImage = FitnessFirst.Properties.Resources.alerton;
            else
                alertBtn.BackgroundImage = FitnessFirst.Properties.Resources.alertoff;
        }
    }
}

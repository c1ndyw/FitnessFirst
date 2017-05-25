using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace FitnessFirst
{
    public partial class Window : Form
    {
        Label time = new Label();
        public static bool homehelp = true, sumhelp = true, calhelp = true, achhelp = true, exehelp = true, foodhelp = true, recall = true;
        public static string hometext = "In this home page, you can do the following things:\n - Go to another pages via menu list on top of this page.\n - Start exercise by selecting exercise on the right first, then\n start the exercise by clicking the start button on the right.";
        public static string sumtext = "In this summary page, you can do the following things:\n - Go to another pages via menu list on top of this page.\n - See the exercises summary on the graph. The detailed date of\n the exercises can be seen by hovering the mouse on the graph\n dots.";
        public static string caltext = "In this calendar page, you can do the following things:\n - Go to another pages via menu list on top of this page.\n - See exercise schedules on the calendar.\n - Add exercise schedule by clicking the '+' button.\n - Go to another calendar's page by clicking the '<' and '>' button.\n Edit or delete the schedule by right clicking the schedule on\n calendar.";
        public static string achtext = "In this achievement page, you can do the following things:\n - Go to another pages via menu list on top of this page.\n - See the achievements available and rewarded.\n - See the detail of the achievement by clicking the achievement.\n - You can get achievements by doing exercises.";
        public static string exetext = "In this exercise page, you can do the following things:\n - Back to previous page by clicking the back button.\n - Start exercise by clicking the start clock button. To pause the\n exercise, simply click the clock again.\n - After you finished the exercise, it will be accumulated and get\n achievement.";
        public static string foodtext = "In this food page, you can do the following things:\n - Go to another pages via menu list on top of this page.\n - See the foods available.\n - See the detail of the food by clicking the food.";
        public SoundPlayer simpleSound = new SoundPlayer(FitnessFirst.Properties.Resources.background);
        public bool play = true;

        public Window()
        {
            InitializeComponent();
            Initialization();
            Controls.Add(LoadingWindow);
            //Global.WaitSomeTime(2000);
            Controls.RemoveAt(0);
            Controls.Add(LoginPage);
        }

        private void Window_Load(object sender, EventArgs e)
        {
        }

        public bool PlyMusic()
        {
            if (play)
            {
                simpleSound.Play();
                return true;
            }
            simpleSound.Stop();
            return false;
        }

        private void Initialization()
        {
            Text = "Fitness Sport";
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            BackColor = Color.LightPink;
            Global.Window = this;
            InitializeExercisePage();
            InitializeLoadingWindow();
            InitializeLoginPage();
            InitializeMainPage();
            InitializeRegisterPage();
            PlyMusic();
        }

        public void InitializeExercisePage()
        {
            ExercisePage = new ExercisePage();
            ExercisePage.Width = this.Width;
            ExercisePage.Height = this.Height;
            ExercisePage.BackColor = Color.White;
        }

        public void InitializeLoadingWindow()
        {
            LoadingWindow = new LoadingControl();
            LoadingWindow.Width = this.Width;
            LoadingWindow.Height = this.Height;
            LoadingWindow.BackColor = Color.Red;
            LoadingWindow.Location = new Point(this.Width / 2 - LoadingWindow.Width / 2, 0);
        }

        public void InitializeLoginPage()
        {
            LoginPage = new LoginPage();
            LoginPage.Location = new Point(this.Width / 2 - LoginPage.Width / 2, this.Height / 2 - LoginPage.Height / 2);
        }

        public void InitializeMainPage()
        {
            MainPage = new MainPage();
            MainPage.Width = this.Width;
            MainPage.Height = this.Height;
            MainPage.BackColor = Color.White;
            MainPage.Location = new Point(this.Width / 2 - MainPage.Width / 2, 0);
        }

        public void InitializeRegisterPage()
        {
            RegisterPage = new RegisterPage();
            RegisterPage.Location = new Point(this.Width / 2 - RegisterPage.Width / 2, this.Height / 2 - RegisterPage.Height / 2);
            RegisterPage.Init(this);
        }

        public Results ChangeWindow(Pages page)
        {
            switch (page)
            {
                case Pages.LoginPage:
                    SetHelps(true);
                    LoginPage.Reset();
                    Controls.RemoveAt(0);
                    Controls.Add(LoginPage);
                    break;
                case Pages.RegisterPage:
                    Controls.RemoveAt(0);
                    Controls.Add(RegisterPage);
                    break;
                case Pages.ExercisePage:
                    ExercisePage.ReSize();
                    ExercisePage.Initialize(Global.CurrentSport);
                    Controls.RemoveAt(0);
                    Controls.Add(ExercisePage);
                    ShowHelp(Pages.ExercisePage, "Exercise Help", exetext, exehelp);
                    break;
                case Pages.MainPage:
                    MainPage.ReSize();
                    MainPage.ChangePage(Pages.HomePage);
                    Controls.RemoveAt(0);
                    Controls.Add(MainPage);
                    if (recall)
                    {
                        MainPage.RecallEvents();
                        recall = false;
                    }
                    ShowHelp(Pages.HomePage, "Home Help", hometext, homehelp);
                    break;
                default:
                    if (MainPage.ChangePage(page) == Results.Failed)
                    {
                        MessageBox.Show("Page is not developed yet", "Page doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return Results.Failed;
                    }
                    break;
            }
            return Results.Success;
        }

        public void SetHelps(bool help)
        {
            homehelp = help;
            sumhelp = help;
            calhelp = help;
            achhelp = help;
            exehelp = help;
            foodhelp = help;
            recall = true;
        }

        public static void ShowHelp(Pages page, string title, string desc, bool help)
        {
            Help h = new Help();
            h.SetText(title, desc);
            if (help)
            {
                if (h.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (page == Pages.HomePage)
                        homehelp = false;
                    else if (page == Pages.CalendarPage)
                        calhelp = false;
                    else if (page == Pages.ExercisePage)
                        exehelp = false;
                    else if (page == Pages.SummaryPage)
                        sumhelp = false;
                    else if (page == Pages.AchievementPage)
                        achhelp = false;
                    h.Close();
                }
            }
        }

        public LoadingControl LoadingWindow { get; set; }
        public LoginPage LoginPage { get; set; }
        public RegisterPage RegisterPage { get; set; }
        public MainPage MainPage { get; set; }
        public ExercisePage ExercisePage { get; set; }
    }
}

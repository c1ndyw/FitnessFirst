using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessFirst
{
    public partial class MainPage : UserControl
    {
        public MainMenuHeader _mainMenuHeader = new MainMenuHeader();
        public HomePage _homePage = new HomePage();
        public CalendarPage _calendarPage = new CalendarPage();
        public GraphPage _graphPage = new GraphPage();
        public FoodPage _settingsPage = new FoodPage();
        public AchievementPage _achievementPage = new AchievementPage();
        public HelpPage _helpPage = new HelpPage();
        public FoodPage _foodPage = new FoodPage();

        private Pages _currentSubPage = Pages.HomePage;

        public MainPage()
        {
            InitializeComponent();
            Initialization();
        }

        private void Initialization()
        {
            BackColor = Color.White;
            this.Controls.Add(_mainMenuHeader);
            this.Controls.Add(_homePage);
        }

        public List<Calendar.NET.IEvent> getEvents()
        {
            return _calendarPage.Calendar.GetEvents();
        }

        public void ReSize()
        {
            UserControl[] _controls = new UserControl[8];
            _controls[0] = _mainMenuHeader;
            _controls[1] = _homePage;
            _controls[2] = _graphPage;
            _controls[3] = _calendarPage;
            _controls[4] = _settingsPage;
            _controls[5] = _achievementPage;
            _controls[6] = _helpPage;
            _controls[7] = _foodPage;
            foreach (UserControl control in _controls)
            {
                if (control != _mainMenuHeader)
                {
                    control.Location = new Point(0, 100);
                    control.Height = this.Height - 100;
                }
                else
                {
                    control.Location = new Point(0, 0);
                    control.Height = 100;
                }
                control.Width = this.Width;
            }
            _mainMenuHeader.ReSize();
            _homePage.ReSize();
            _calendarPage.ReSize();
            _graphPage.ReSize();
            _settingsPage.ReSize();
            _achievementPage.ReSize();
            _helpPage.ReSize();
            _foodPage.ReSize();
        }

        public Results ChangePage(Pages page)
        {
            switch (page)
            {
                case Pages.HomePage:
                    _homePage.ReSize();
                    Controls.RemoveAt(1);
                    Controls.Add(_homePage);
                    break;
                case Pages.CalendarPage:
                    _calendarPage.ReSize();
                    _calendarPage.InitEvent();
                    Controls.RemoveAt(1);
                    Controls.Add(_calendarPage);
                    Window.ShowHelp(Pages.CalendarPage, "Calendar Help", Window.caltext, Window.calhelp);
                    break;
                case Pages.SummaryPage:
                    _graphPage.ReSize();
                    _graphPage.InitializeGraph();
                    Controls.RemoveAt(1);
                    Controls.Add(_graphPage);
                    Window.ShowHelp(Pages.SummaryPage, "Summary Help", Window.sumtext, Window.sumhelp);
                    break;
                case Pages.SettingsPage:
                    _settingsPage.ReSize();
                    Controls.RemoveAt(1);
                    Controls.Add(_settingsPage);
                    break;
                case Pages.AchievementPage:
                    _achievementPage.ReSize();
                    _achievementPage.SetAchievement();
                    Controls.RemoveAt(1);
                    Controls.Add(_achievementPage);
                    Window.ShowHelp(Pages.AchievementPage, "Achievement Help", Window.achtext, Window.achhelp);
                    break;
                case Pages.FoodPage:
                    _foodPage.ReSize();
                    Controls.RemoveAt(1);
                    Controls.Add(_foodPage);
                    Window.ShowHelp(Pages.FoodPage, "Food Help", Window.foodtext, Window.foodhelp);
                    break;
                default:
                    return Results.Failed;
            }
            _currentSubPage = page;
            return Results.Success;
        }

        public void RecallEvents()
        {
            _calendarPage.Calendar.UserId = Global.user.id;
            _calendarPage.InitEvent();
            _mainMenuHeader.RecallEvents();
        }
    }
}

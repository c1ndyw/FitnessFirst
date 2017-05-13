using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainPage : UserControl
    {
        MainMenuHeader _mainMenuHeader = new MainMenuHeader();
        HomePage _homePage = new HomePage();
        CalendarPage _calendarPage = new CalendarPage();
        GraphPage _graphPage = new GraphPage();
        SettingsPage _settingsPage = new SettingsPage();
        HelpPage _helpPage = new HelpPage();

        private UserControl[] _controls = new UserControl[6];

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            init();
            this.Controls.Add(_mainMenuHeader);
            this.Controls.Add(_homePage);
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(1);
            this.Controls.Add(_calendarPage);
        }

        private void graphBtn_Click(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(1);
            this.Controls.Add(_graphPage);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(1);
            this.Controls.Add(_homePage);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(1);
            this.Controls.Add(_settingsPage);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(1);
            this.Controls.Add(_helpPage);
        }

        private void init()
        {
            _controls[0] = _mainMenuHeader;
            _controls[1] = _homePage;
            _controls[2] = _calendarPage;
            _controls[3] = _graphPage;
            _controls[4] = _settingsPage;
            _controls[5] = _helpPage;
            foreach (UserControl control in _controls)
            {
                if (control != _mainMenuHeader)
                    control.Location = new Point(0, 100);
                else
                    control.Location = new Point(0, 0);
            }
            _mainMenuHeader.getButton("home").Click += new EventHandler(homeBtn_Click);
            _mainMenuHeader.getButton("calendar").Click += new EventHandler(calendarBtn_Click);
            _mainMenuHeader.getButton("graph").Click += new EventHandler(graphBtn_Click);
            _mainMenuHeader.getButton("settings").Click += new EventHandler(settingsBtn_Click);
        }

        public void ReSize()
        {
            foreach (UserControl control in _controls)
            {
                control.Width = this.Width;
                control.Height = this.Height - 100;
                control.BackColor = Color.Brown;
            }
            _homePage.ReSize();
            //_calendarPage.ReSize();
            _graphPage.ReSize();
            _mainMenuHeader.Width = this.Width;
            _mainMenuHeader.Height = 100;
            _mainMenuHeader.BackColor = Color.Blue;
            _mainMenuHeader.resize();
        }
    }
}

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

namespace WindowsFormsApplication1
{
    public partial class Window : Form
    {
        LoadingControl _loadingWindow = new LoadingControl();
        LoginPage _loginPage = new LoginPage();
        MainPage _mainPage = new MainPage();
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            init();
            this.Controls.Add(_loadingWindow);
            this.Text = "Fitness Sport";
            //Global.WaitSomeTime(2000);
            this.Controls.RemoveAt(0);
            this.Controls.Add(_loginPage);
            addClick();
        }

        private void init()
        {
            _loadingWindow.Width = this.Width;
            _loadingWindow.Height = this.Height;
            _loadingWindow.BackColor = Color.Red;
            _loadingWindow.Location = new Point(this.Width / 2 - _loadingWindow.Width / 2, 0);
            _mainPage.Width = this.Width;
            _mainPage.Height = this.Height;
            _mainPage.BackColor = Color.Black;
            _mainPage.Location = new Point(this.Width / 2 - _mainPage.Width / 2, 0);
            _loginPage.Location = new Point(this.Width / 2 - _loginPage.Width / 2, this.Height / 2 - _loginPage.Height / 2);
        }

        private void addClick()
        {
            _loginPage.getButton("logIn").Click += new EventHandler(login);
        }

        private void login(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(0);
            this.Controls.Add(_mainPage);
            _mainPage.ReSize();      
        }

        private void forgotPass(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(0);
            this.Controls.Add(_mainPage);
        }

        private void newAcc(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(0);
            this.Controls.Add(_mainPage);
        }
    }
}

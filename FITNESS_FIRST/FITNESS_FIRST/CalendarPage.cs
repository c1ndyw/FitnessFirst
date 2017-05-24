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

namespace FitnessFirst
{
    public partial class CalendarPage : UserControl
    {
        Calendar.NET.Calendar _calendar = new Calendar.NET.Calendar();
        Label _title = new Label();

        public CalendarPage()
        {
            InitializeComponent();
            Initialization();
        }

        public void Initialization()
        {
            _title.Text = "Your Schedule";
            _title.Font = Global.TitleFont2;
            _title.BackColor = Color.Transparent;
            _title.TextAlign = ContentAlignment.MiddleCenter;
            _title.Location = new Point(10, 10);
            _calendar.Location = new Point(10, 110);
        }

        private void InitializeTitle()
        {
            _title.Text = "Your Work Summary";
            _title.Font = Global.TitleFont2;
            _title.BackColor = Color.Transparent;
            _title.TextAlign = ContentAlignment.MiddleCenter;
            _title.Location = new Point(10, 10);
            _title.Width = this.Width - 20;
            _title.Height = 100;
            Controls.Add(_title);
        }

        public void ReSize()
        {
            _title.Width = this.Width - 20;
            _title.Height = 100;
            _calendar.Width = this.Width - 50;
            _calendar.Height = this.Height - 150;
        }

        public void InitEvent()
        {
            _calendar.InitEvent();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 1);
            Brush b = Brushes.LightSlateGray;
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawLine(pen, _calendar.Location.X, _calendar.Location.Y - 10, _calendar.Location.X + _calendar.Width, _calendar.Location.Y - 10);
        }

        private void CalendarPage_Load(object sender, EventArgs e)
        {
            ReSize();
            Controls.Add(_title);
            Controls.Add(_calendar);
        }

        public Calendar.NET.Calendar Calendar
        {
            get
            {
                return _calendar;
            }
        }
    }
}

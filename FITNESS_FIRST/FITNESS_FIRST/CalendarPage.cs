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
        private Calendar.NET.Calendar _calendar = new Calendar.NET.Calendar();
        public CalendarPage()
        {
            InitializeComponent();
        }

        public void ReSize()
        {
            _calendar.Location = new Point(10, 10);
            _calendar.Width = this.Width - 20;
            _calendar.Height = this.Height - 50;
        }

        private void CalendarPage_Load(object sender, EventArgs e)
        {
            ReSize();
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

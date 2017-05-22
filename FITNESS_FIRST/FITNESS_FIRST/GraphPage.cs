using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace FitnessFirst
{
    public partial class GraphPage : UserControl
    {
        List<DateTime> dates = new List<DateTime>();
        Label _title = new Label();
        int border = 100;

        public GraphPage()
        {
            InitializeComponent();
            Initialization();
        }

        public void Initialization()
        {
            this.BackColor = Color.White;
            InitializeTitle();
            //InitializeGraph();
        }

        private void InitializeTitle()
        {
            _title.Text = "Your Work Summary";
            _title.Font = Global.TitleFont2;
            _title.BackColor = Color.Transparent;
            _title.TextAlign = ContentAlignment.MiddleCenter;
            _title.Location = new Point(10, 10);
            _title.Size = new System.Drawing.Size(this.Width - 20, 100);
            Controls.Add(_title);
        }

        public bool InitializeGraph()
        {
            //chart1.DataSource = Global.conn;
            dates.Clear();
            SqlCommand command = new SqlCommand("select date,count from [exercise] where userid = @userid", Global.conn);
            command.Parameters.AddWithValue("@userid", Global.user.id);
            SqlCommand command2 = new SqlCommand("select date from [exercise] where userid = @userid", Global.conn);
            command2.Parameters.AddWithValue("@userid", Global.user.id);
            try
            {
                Global.conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                chart1.Series.Clear();
                chart1.DataBindTable(reader, "Date");
                reader.Close();
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    dates.Add(Convert.ToDateTime(reader2[0]));
                }
                reader2.Close();
                Global.conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Graph init failed" + ex);
                return false;
            }
            //exerciseTableAdapter.Fill(fitnessfirstDataSet.Exercise);
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[0].LegendText = "Exercise Counts";
            chart1.Series[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            chart1.Series[0].MarkerSize = 10;
            chart1.Series[0].MarkerColor = Color.Black;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            for (int i = 0; i < chart1.Series[0].Points.Count; i++ )
            {
                chart1.Series[0].Points[i].ToolTip = dates[i].ToShortDateString();
            }
            return true;
        }

        public void ReSize()
        {
            _title.Width = this.Width - 20;
            _title.Height = 100;
            chart1.Location = new Point(border, border + 10);
            chart1.Size = new Size(this.Width - border * 2, this.Height - border * 2 - 10);
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 1);
            Brush b = Brushes.LightSlateGray;
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawLine(pen, chart1.Location.X, chart1.Location.Y - 10, chart1.Location.X + chart1.Width, chart1.Location.Y - 10);
        }

        /// <summary>
        /// For UnitTest
        /// </summary>
        public Chart Chart
        {
            get { return chart1; }
        }
        public void setLocation()
        {
            chart1.Location = new Point(border, border);
        }
        public void setSize()
        {
            chart1.Size = new Size(this.Width - border * 2, this.Height - border * 2);
        }
    }
}

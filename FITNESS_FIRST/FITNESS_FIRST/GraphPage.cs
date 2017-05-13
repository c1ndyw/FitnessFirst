using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace FitnessFirst
{
    public partial class GraphPage : UserControl
    {
        private int border = 100;
        public GraphPage()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            this.BackColor = Color.White;
            exerciseTableAdapter.Fill(fitnessfirstDataSet.Exercise);
        }

        public void ReSize()
        {
            setLocation();
            setSize();
        }

        
        private void GraphPage_Load(object sender, EventArgs e)
        {
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

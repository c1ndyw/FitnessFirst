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
    public partial class MainMenuHeader2 : UserControl
    {
        public MainMenuHeader2()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            this.BackColor = Color.FromArgb(255, 76, 76);
            backBtn.Text = "";
            backBtn.Name = "back";
            backBtn.Cursor = Cursors.Hand;
            backBtn.BackgroundImage = FitnessFirst.Properties.Resources.home;
            backBtn.BackgroundImageLayout = ImageLayout.Zoom;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.Click += new EventHandler(Back);
        }

        public void ReSize()
        {
            this.Height = 100;
            Title.Text = "Fitness First";
            Title.Location = new Point(this.Width / 2 - 100, 30);
            backBtn.Location = new Point(20, 0);
            backBtn.Width = Global.ButtonSize;
            backBtn.Height = Global.ButtonSize;
        }

        public void Back(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel stop exercise?", "Stopping Exercise", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                ExercisePage ex = (ExercisePage)Parent;
                ex.Reset();
                Global.ChangePage(Pages.MainPage);
            }
        }
    }
}

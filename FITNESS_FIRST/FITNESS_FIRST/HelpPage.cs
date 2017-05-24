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
    public partial class HelpPage : UserControl
    {
        Form f = null;

        public HelpPage()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            BackColor = Color.White;
            title.Font = Global.TitleFont;
            desc.Font = Global.CustomFont;
            OkBtn.FlatAppearance.BorderSize = 0;
            OkBtn.FlatStyle = FlatStyle.Flat;
            OkBtn.Font = Global.ButtonFont;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = Global.ButtonFont;
            Visible = false;
        }

        public void Show(string title, string desc)
        {
            ReSize();
            this.title.Text = title;
            this.desc.Text = desc;
            this.Visible = true;
        }

        public void ReSize()
        {
            Size = new Size(300, 300);
            Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2);
            title.Location = new Point(20, 20);
            title.Width = Width - 40;
            desc.Location = new Point(20, 80);
            desc.Width = Width - 40;
            CancelBtn.Location = new Point(Width - 100);
            CancelBtn.Width = 75;
            OkBtn.Location = new Point(Width - 200);
            OkBtn.Width = 75;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}

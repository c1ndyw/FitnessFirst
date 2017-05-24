using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessFirst
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            Initialize();
            ReSize();
        }

        public void Initialize()
        {
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.White;
            title.Font = Global.TitleFont;
            desc.Font = Global.CustomFont;
            OkBtn.FlatAppearance.BorderSize = 0;
            OkBtn.FlatStyle = FlatStyle.Flat;
            OkBtn.Font = Global.ButtonFont;
        }

        public void SetText(string title, string desc)
        {
            this.title.Text = title;
            this.desc.Text = desc;
        }

        public void ReSize()
        {
            Size = new Size(620, 400);
            StartPosition = FormStartPosition.CenterScreen;
            title.Location = new Point(20, 20);
            title.Width = Width - 60;
            desc.Location = new Point(20, 80);
            desc.Width = Width - 60;
            OkBtn.Location = new Point(Width - 130, Height - 100);
            OkBtn.Size = new System.Drawing.Size(100, 50);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Help_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2), 0, 0, Width - 4, Height - 4);
        }

        public Label Title
        {
            get { return title; }
        }

        public Label Desc
        {
            get { return desc; }
        }

        public Button OkButton
        {
            get { return OkBtn; }
        }
    }
}

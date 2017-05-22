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
    public partial class FoodBox : Form
    {
        public FoodBox()
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
            picture.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void SetText(string title, string desc, Image pic)
        {
            this.title.Text = title;
            this.desc.Text = desc;
            this.picture.BackgroundImage = pic;
        }

        public void ReSize()
        {
            Size = new Size(620, 300);
            StartPosition = FormStartPosition.CenterScreen;
            picture.Width = 200;
            picture.Height = 200;
            title.Location = new Point(picture.Width + 20, 20);
            title.Width = Width - picture.Width - 60;
            desc.Location = new Point(title.Location.X, 80);
            desc.Width = title.Width - 60;
            desc.Height = Height - 130;
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

        public PictureBox Picture
        {
            get { return picture; }
        }
    }
}

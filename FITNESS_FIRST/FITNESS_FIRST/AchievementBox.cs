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
    public partial class AchievementBox : UserControl
    {
        private Label _title;
        private Label _desc;
        private PictureBox _images;
        public bool clicked = false;
        public string howtoget = "";

        public AchievementBox()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            _title = new Label();
            _desc = new Label();
            _images = new PictureBox();
            _images.MouseEnter += new EventHandler(hover);
            _images.MouseLeave += new EventHandler(leave);
            Controls.Add(_images);
            Controls.Add(_title);
            Controls.Add(_desc);
        }

        public void hover(object sender, EventArgs e)
        {
            if (!clicked)
                this.BackColor = Color.LightGray;
        }

        public void leave(object sender, EventArgs e)
        {
            if (!clicked)
                this.BackColor = Color.White;
        }

        public Label Title()
        {
            return _title;
        }

        public Label Desc()
        {
            return _desc;
        }

        public PictureBox Images()
        {
            return _images;
        }
    }
}

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
    public partial class FoodPage : UserControl
    {
        private Label _title = new Label();
        private Label _desc = new Label();
        private List<AchievementBox> _foodBtn;
        private AchievementBox _chosen;
        private FoodBox _foodBox;
        private int border = 100;

        public FoodPage()
        {
            InitializeComponent();
            Initialize();
            InitializeTitle();
            InitializeDesc();
        }

        public void Initialize()
        {
            this.BackColor = Color.White;
            Global.SetDefaultFoods();
            _foodBtn = new List<AchievementBox>();
            foodContainer.BackColor = Color.Transparent;
            _foodBox = new FoodBox();
        }

        public void InitializeTitle()
        {
            _title.Text = "Food Suggestions";
            _title.Font = Global.TitleFont2;
            _title.BackColor = Color.Transparent;
            _title.TextAlign = ContentAlignment.MiddleCenter;
            _title.Size = new System.Drawing.Size(foodContainer.Width + 300, 35);
            Controls.Add(_title);
        }

        public void InitializeDesc()
        {
            _desc.Text = "List of foods";
            _desc.Font = Global.CustomFont;
            _desc.BackColor = Color.Transparent;
            _desc.TextAlign = ContentAlignment.MiddleCenter;
            _desc.Size = new System.Drawing.Size(foodContainer.Width + 300, 35);
            Controls.Add(_desc);
        }

        public void ReSize()
        {
            foodContainer.Location = new Point(border, border);
            foodContainer.Size = new System.Drawing.Size(this.Width - border * 2, this.Width - border * 2);
            SetButtons();
            _title.Location = new Point(foodContainer.Location.X, 20);
            _desc.Location = new Point(foodContainer.Location.X, 55);
            _foodBox.ReSize();
        }

        public void SetButtons()
        {
            int buttonSize = (int)(foodContainer.Width / 5);
            int row = 0, col = 0;
            for (int i = 0; i < Global.DefaultFoods.Count; i++)
            {
                _foodBtn.Add(new AchievementBox());
                _foodBtn[i].Name = Global.DefaultFoods[i].title;
                _foodBtn[i].Location = new Point(col * buttonSize + 1 + foodContainer.Width / 2 - buttonSize * 2, row * buttonSize + 1);
                _foodBtn[i].Width = buttonSize - 2;
                _foodBtn[i].Height = buttonSize - 2;
                _foodBtn[i].BackColor = Color.Transparent;
                _foodBtn[i].Visible = true;
                _foodBtn[i].Images().Location = new Point(5, 5);
                _foodBtn[i].Images().Width = _foodBtn[i].Width - 10;
                _foodBtn[i].Images().Height = _foodBtn[i].Height - 90;
                _foodBtn[i].Images().BackgroundImage = Global.DefaultFoods[i].image;
                _foodBtn[i].Images().BackgroundImageLayout = ImageLayout.Zoom;
                _foodBtn[i].Images().Cursor = Cursors.Hand;
                _foodBtn[i].Images().Click -= new EventHandler(ChooseFood);
                _foodBtn[i].Images().Click += new EventHandler(ChooseFood);
                _foodBtn[i].Title().Text = Global.DefaultFoods[i].title;
                _foodBtn[i].Title().Location = new Point(5, _foodBtn[i].Images().Height + 10);
                _foodBtn[i].Title().Width = _foodBtn[i].Width - 5;
                _foodBtn[i].Title().Height = 30;
                _foodBtn[i].Title().Font = new System.Drawing.Font("Arial", 14);
                _foodBtn[i].Title().TextAlign = ContentAlignment.MiddleCenter;
                _foodBtn[i].Title().ForeColor = Color.DarkRed;
                _foodBtn[i].Desc().Text = Global.DefaultFoods[i].desc;
                _foodBtn[i].Desc().Location = new Point(5, _foodBtn[i].Images().Height + 40);
                _foodBtn[i].Desc().Width = _foodBtn[i].Width;
                _foodBtn[i].Desc().Height = 50;
                _foodBtn[i].Desc().Font = new System.Drawing.Font("Arial", 14);
                _foodBtn[i].Desc().TextAlign = ContentAlignment.MiddleCenter;
                _foodBtn[i].Desc().ForeColor = Color.IndianRed;
                _foodBtn[i].howtoget = Global.DefaultFoods[i].howtoget;
                col++;
                if (col >= 4)
                {
                    col = 0;
                    row++;
                }
                foodContainer.Controls.Add(_foodBtn[i]);
            }
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 1);
            Brush b = Brushes.LightSlateGray;
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawLine(pen, foodContainer.Location.X, foodContainer.Location.Y - 10, foodContainer.Location.X + foodContainer.Width, foodContainer.Location.Y - 10);
            if (_chosen != null)
            {
                e.Graphics.FillRectangle(b, foodContainer.Location.X + _chosen.Location.X - 2, foodContainer.Location.Y + _chosen.Location.Y - 2, _chosen.Width + 4, _chosen.Height + 4);
            }
        }

        public void ShowDetail()
        {
            _foodBox.SetText(_chosen.Title().Text, _chosen.Desc().Text, _chosen.Images().BackgroundImage);
            if (_foodBox.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        public void ChooseFood(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            ChooseFood(p);
            Invalidate();
        }

        public void ChooseFood(PictureBox p)
        {
            if (_chosen == null || _chosen != (AchievementBox)p.Parent)
            {
                if (_chosen != null)
                {
                    _chosen.clicked = false;
                    _chosen.BackColor = Color.White;
                }
                _chosen = (AchievementBox)p.Parent;
                _chosen.clicked = true;
                ShowDetail();
            }
            else
            {
                _chosen = null;
            }
        }

        public Label Title
        {
            get { return _title; }
        }

        public Label Desc
        {
            get { return _desc; }
        }
    }
}

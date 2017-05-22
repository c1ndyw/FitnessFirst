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
    public partial class AchievementPage : UserControl
    {
        private Label _title = new Label();
        private Label _desc = new Label();
        private Label _title2 = new Label();
        private Label _desc2 = new Label();
        private PictureBox _picture = new PictureBox();
        private Panel _achievementDetail = new Panel();
        private List<AchievementBox> _achievementBtn;
        private AchievementBox _chosen;
        private int border = 100;

        public AchievementPage()
        {
            InitializeComponent();
            Initialize();
            InitializeTitle();
            InitializeDesc();
            InitializePicture();
            Controls.Add(_achievementDetail);
        }

        public void Initialize()
        {
            this.BackColor = Color.White;
            Global.SetDefaultAchievements();
            _achievementBtn = new List<AchievementBox>();
            achievementContainer.BackColor = Color.Transparent;
            _achievementDetail.BackColor = Color.LightGray;
            _achievementDetail.Visible = false;
        }

        private void InitializePicture()
        {
            _picture.BackColor = Color.Transparent;
            _picture.Size = new System.Drawing.Size(250, 250);
            _picture.BackgroundImageLayout = ImageLayout.Zoom;
            _picture.BackColor = Color.White;
            _achievementDetail.Controls.Add(_picture);
        }

        private void InitializeTitle()
        {
            _title.Text = "Achievements";
            _title.Font = Global.TitleFont2;
            _title.BackColor = Color.Transparent;
            _title.TextAlign = ContentAlignment.MiddleCenter;
            _title.Size = new System.Drawing.Size(achievementContainer.Width + 300, 35);
            _title2.Text = "?";
            _title2.Font = Global.TitleFont2;
            _title2.BackColor = Color.Transparent;
            _title2.Size = new System.Drawing.Size(300, 35);
            _achievementDetail.Controls.Add(_title2);
            Controls.Add(_title);
        }

        private void InitializeDesc()
        {
            _desc.Text = "List of achievements";
            _desc.Font = Global.CustomFont;
            _desc.BackColor = Color.Transparent;
            _desc.TextAlign = ContentAlignment.MiddleCenter;
            _desc.Size = new System.Drawing.Size(achievementContainer.Width + 300, 35);
            _desc2.Text = "?";
            _desc2.Font = Global.CustomFont;
            _desc2.BackColor = Color.Transparent;
            _desc2.Size = new System.Drawing.Size(400, 35);
            _achievementDetail.Controls.Add(_desc2);
            Controls.Add(_desc);
        }

        public void ReSize()
        {
            achievementContainer.Location = new Point(border, border);
            achievementContainer.Size = new System.Drawing.Size(this.Width - border * 2, (int)(achievementContainer.Width / 5));
            _achievementDetail.Size = new System.Drawing.Size(600, _picture.Height + 20);
            _achievementDetail.Location = new Point(Width / 2 - _achievementDetail.Width / 2, border + achievementContainer.Height + 10);
            SetButtons();
            _picture.Location = new Point(10, 10);
            _title.Location = new Point(achievementContainer.Location.X, 20);
            _desc.Location = new Point(achievementContainer.Location.X, 55);
            _title2.Location = new Point(_picture.Width + 20, 20);
            _desc2.Location = new Point(_picture.Width + 20, 55);
        }

        public void SetAchievement()
        {
            Global.SynchronizeAchievement();
            for (int i = 0; i < Global.DefaultAchievements.Count; i++)
            {
                foreach (Achievement a in Global.Achievements)
                {
                    if (Global.DefaultAchievements[i].title == a.title)
                    {
                        _achievementBtn[i].Images().BackgroundImage = Global.DefaultAchievements[i].image;
                        _achievementBtn[i].Title().Text = Global.DefaultAchievements[i].title;
                        _achievementBtn[i].Desc().Text = Global.DefaultAchievements[i].desc;
                        break;
                    }
                }
            }
            _chosen = null;
            _achievementDetail.Visible = false;
        }

        public void SetButtons()
        {
            int buttonSize = (int)(achievementContainer.Width / 5);
            int row = 0, col = 0;
            for(int i = 0; i<Global.DefaultAchievements.Count; i++)
            {
                _achievementBtn.Add(new AchievementBox());
                _achievementBtn[i].Name = Global.DefaultAchievements[i].title;
                _achievementBtn[i].Location = new Point(col * buttonSize + 1 + achievementContainer.Width / 2 - buttonSize * 2, row * buttonSize + 1);
                _achievementBtn[i].Width = buttonSize - 2;
                _achievementBtn[i].Height = buttonSize - 2;
                _achievementBtn[i].BackColor = Color.Transparent;
                _achievementBtn[i].Visible = true;
                _achievementBtn[i].Images().Location = new Point(5, 5);
                _achievementBtn[i].Images().Width = _achievementBtn[i].Width - 10;
                _achievementBtn[i].Images().Height = _achievementBtn[i].Height - 90;
                _achievementBtn[i].Images().BackgroundImage = Properties.Resources.Empty;
                _achievementBtn[i].Images().BackgroundImageLayout = ImageLayout.Zoom;
                _achievementBtn[i].Images().Cursor = Cursors.Hand;
                _achievementBtn[i].Images().Click -= new EventHandler(ChooseAchievement);
                _achievementBtn[i].Images().Click += new EventHandler(ChooseAchievement);
                _achievementBtn[i].Title().Text = "???";
                _achievementBtn[i].Title().Location = new Point(5, _achievementBtn[i].Images().Height + 10);
                _achievementBtn[i].Title().Width = _achievementBtn[i].Width - 5;
                _achievementBtn[i].Title().Height = 30;
                _achievementBtn[i].Title().Font = new System.Drawing.Font("Arial", 14);
                _achievementBtn[i].Title().TextAlign = ContentAlignment.MiddleCenter;
                _achievementBtn[i].Title().ForeColor = Color.DarkRed;
                _achievementBtn[i].Desc().Text = "";
                _achievementBtn[i].Desc().Location = new Point(5, _achievementBtn[i].Images().Height + 40);
                _achievementBtn[i].Desc().Width = _achievementBtn[i].Width;
                _achievementBtn[i].Desc().Height = 50;
                _achievementBtn[i].Desc().Font = new System.Drawing.Font("Arial", 14);
                _achievementBtn[i].Desc().TextAlign = ContentAlignment.MiddleCenter;
                _achievementBtn[i].Desc().ForeColor = Color.IndianRed;
                _achievementBtn[i].howtoget = Global.DefaultAchievements[i].howtoget;
                col++;
                if (col >= 4)
                {
                    col = 0;
                    row++;
                }
                achievementContainer.Controls.Add(_achievementBtn[i]);
            }
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 1);
            Brush b = Brushes.LightSlateGray;
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawLine(pen, achievementContainer.Location.X, achievementContainer.Location.Y - 10, achievementContainer.Location.X + achievementContainer.Width, achievementContainer.Location.Y - 10);
            if (_chosen != null)
            {
                e.Graphics.FillRectangle(b, achievementContainer.Location.X + _chosen.Location.X - 2, achievementContainer.Location.Y + _chosen.Location.Y - 2, _chosen.Width + 4, _chosen.Height + 4);
            }
        }

        private void ShowDetail()
        {
            _picture.BackgroundImage = _chosen.Images().BackgroundImage;
            _title2.Text = _chosen.Title().Text;
            _desc2.Text = _chosen.Desc().Text + "\n\n" + _chosen.howtoget;
            _achievementDetail.Visible = true;
        }

        private void ChooseAchievement(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
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
                _achievementDetail.Visible = false;
            }
            Invalidate();
        }

        public List<AchievementBox> AchievementBox { get { return _achievementBtn; } }
    }
}

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
    public partial class HomePage : UserControl
    {
        private Label instructionTitle = new Label();
        private Label instructionText = new Label();
        private Button choosen;
        private Button[] exercisesBtn;
        private int border = 100;
        
        public HomePage()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            this.BackColor = Color.White;
            Global.DefaultSport();
            exercisesBtn = new Button[Global.Sports.Count];
            startBtn.Location = new Point(border, border);
            startBtn.BackColor = Color.Transparent;
            startBtn.BackgroundImage = FitnessFirst.Properties.Resources.startclock;
            startBtn.BackgroundImageLayout = ImageLayout.Zoom;
            startBtn.Cursor = Cursors.Hand;
            startBtn.Click += new EventHandler(StartExercise);
            sportContainer.BackColor = Color.Transparent;
            instructionTitle.Text = "Instructions";
            instructionTitle.Font = new System.Drawing.Font("Arial", 14);
            instructionText.Text = "1. Select the sport on the right.\n2. Click start button on the left.";
            instructionText.Font = new System.Drawing.Font("Arial", 12);
            instructionText.BackColor = Color.Transparent;
            instructionText.Size = new System.Drawing.Size(sportContainer.Width + 300, 50);
            Controls.Add(instructionTitle);
            Controls.Add(instructionText);
        }

        public void ReSize()
        {
            startBtn.Width = (int)(this.Width * 2 / 5) - border * 2;
            startBtn.Height = this.Height - border * 2;
            sportContainer.Location = new Point(startBtn.Width + border * 3, border + 50);
            sportContainer.Width = (int)(this.Width * 3 / 5) - border * 2;
            sportContainer.Height = this.Height - border * 2 - 50;
            SetButtons();
            instructionTitle.Location = new Point(sportContainer.Location.X, sportContainer.Location.Y - 90);
            instructionText.Location = new Point(sportContainer.Location.X, sportContainer.Location.Y - 50);
        }

        public void SetButtons()
        {
            int buttonSize = (int)(sportContainer.Width / 3);
            int row = 0, col = 0;
            for(int i = 0; i<Global.Sports.Count; i++)
            {
                Button b = new Button();
                b.Name = Global.Sports[i];
                b.Location = new Point(col * buttonSize + 1, row * buttonSize + 1);
                b.Width = buttonSize - 2;
                b.Height = buttonSize - 2;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = Color.Transparent;
                b.BackgroundImage = FitnessFirst.Properties.Resources.melon;
                b.BackgroundImageLayout = ImageLayout.Zoom;
                b.Cursor = Cursors.Hand;
                b.Click += new EventHandler(ChooseExercise);
                exercisesBtn[i] = new Button();
                exercisesBtn[i] = b;
                col++;
                if (col >= 3)
                {
                    col = 0;
                    row++;
                }
                sportContainer.Controls.Add(b);
            }
            exercisesBtn[0].BackgroundImage = FitnessFirst.Properties.Resources.jumpingjacks;
            exercisesBtn[1].BackgroundImage = FitnessFirst.Properties.Resources.wallsit;
            exercisesBtn[2].BackgroundImage = FitnessFirst.Properties.Resources.pushups;
            exercisesBtn[3].BackgroundImage = FitnessFirst.Properties.Resources.crunches;
            exercisesBtn[4].BackgroundImage = FitnessFirst.Properties.Resources.lunges;
            exercisesBtn[5].BackgroundImage = FitnessFirst.Properties.Resources.squats;
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 1);
            Brush b = Brushes.LightSlateGray;
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawLine(pen, startBtn.Width + border * 5/2, border, startBtn.Width + border * 5/2, this.Height - border);
            if (choosen != null)
            {
                e.Graphics.FillRectangle(b, sportContainer.Location.X + choosen.Location.X - 2, sportContainer.Location.Y + choosen.Location.Y - 2, choosen.Width + 4, choosen.Height + 4);
            }
        }

        private void ChooseExercise(object sender, EventArgs e)
        {
            choosen = (Button)sender;
            Invalidate();
        }

        private void StartExercise(object sender, EventArgs e)
        {
            if (choosen != null)
            {
                Window w = (Window)Parent.Parent;
                w.Exercise();
            }
            else
            {
                MessageBox.Show("Please select an exercise first", "Error");
            }
        }
    }
}

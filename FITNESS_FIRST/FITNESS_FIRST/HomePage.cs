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
        Label instructionTitle = new Label();
        Label instructionText = new Label();
        Label _title = new Label();
        Label _exerciseTimeLabel = new Label();
        TextBox _exerciseTime = new TextBox();
        Button _chosen = null, startButton = new Button();
        Button[] exercisesBtn;
        ToolTip hint = new ToolTip();

        int border = 100;
        
        public HomePage()
        {
            InitializeComponent();
            Initialization();
        }

        public void Initialization()
        {
            this.BackColor = Color.White;
            InitializeTitle();
            exercisesBtn = new Button[6];
            startBtn.BackColor = Color.Transparent;
            startButton.BackColor = Color.Transparent;
            startButton.BackgroundImage = FitnessFirst.Properties.Resources.start;
            startButton.BackgroundImageLayout = ImageLayout.Zoom;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Click += new EventHandler(StartExercise);
            sportContainer.BackColor = Color.Transparent;
            instructionTitle.Text = "Instructions";
            instructionTitle.Font = new System.Drawing.Font("Arial", 14);
            instructionText.Text = "1. Select the sport on the right.\n2. Click start button on the left.";
            instructionText.Font = new System.Drawing.Font("Arial", 12);
            instructionText.BackColor = Color.Transparent;
            instructionText.Size = new System.Drawing.Size(sportContainer.Width + 300, 50);
            _exerciseTimeLabel.Text = "Exercise time: ";
            _exerciseTimeLabel.Font = Global.CustomFont2;
            _exerciseTimeLabel.BackColor = Color.Transparent;
            _exerciseTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            _exerciseTime.Text = "10";
            _exerciseTime.Font = Global.InputFont2;
            _exerciseTime.BackColor = Color.White;
            _exerciseTime.KeyPress += new KeyPressEventHandler(numberOnly);
            hint.SetToolTip(startButton, "Button to start the exercise");
            hint.SetToolTip(sportContainer, "Choose one of the exercise");
            Controls.Add(instructionTitle);
            Controls.Add(instructionText);
            startBtn.Controls.Add(startButton);
            startBtn.Controls.Add(_exerciseTimeLabel);
            startBtn.Controls.Add(_exerciseTime);
        }

        private void InitializeTitle()
        {
            _title.Text = "Start Exercise";
            _title.Font = Global.TitleFont2;
            _title.BackColor = Color.Transparent;
            _title.TextAlign = ContentAlignment.MiddleCenter;
            _title.Location = new Point(10, 10);
            Controls.Add(_title);
        }

        public void ReSize()
        {
            startBtn.Location = new Point(40, 120);
            startBtn.Width = (int)(this.Width * 2 / 5);
            startBtn.Height = this.Height - border * 2;
            sportContainer.Location = new Point(startBtn.Width + 70, border * 2 + 20);
            sportContainer.Width = (int)(this.Width * 3 / 5) - border * 2;
            sportContainer.Height = this.Height - border * 2;
            _title.Size = new System.Drawing.Size(this.Width - 40, 100);
            startButton.Location = new Point(0, 0);
            startButton.Size = new System.Drawing.Size(startBtn.Width, startBtn.Height - 50);
            SetButtons();
            instructionTitle.Location = new Point(sportContainer.Location.X, sportContainer.Location.Y - 90);
            instructionText.Location = new Point(sportContainer.Location.X, sportContainer.Location.Y - 50);
            _exerciseTimeLabel.Size = new System.Drawing.Size(startBtn.Width / 2, 35);
            _exerciseTimeLabel.Location = new Point(0, startButton.Height + 10);
            _exerciseTime.Size = new System.Drawing.Size(150, 35);
            _exerciseTime.Location = new Point(startBtn.Width / 2, startButton.Height + 10);
        }

        public void SetButtons()
        {
            int buttonSize = (int)(sportContainer.Width / 3);
            int row = 0, col = 0;
            for(int i = 0; i<6; i++)
            {
                Button b = new Button();
                b.Location = new Point(col * buttonSize + 1, row * buttonSize + 1);
                b.Width = buttonSize - 2;
                b.Height = buttonSize - 2;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = Color.Transparent;
                b.BackgroundImage = FitnessFirst.Properties.Resources.melon;
                b.BackgroundImageLayout = ImageLayout.Zoom;
                b.Cursor = Cursors.Hand;
                b.Click -= new EventHandler(ChooseExercise);
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
            exercisesBtn[0].Name = "JumpingJacks";
            exercisesBtn[1].Name = "WallSit";
            exercisesBtn[2].Name = "PushUp";
            exercisesBtn[3].Name = "Crunches";
            exercisesBtn[4].Name = "Lunges";
            exercisesBtn[5].Name = "Squat";
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 1);
            Brush b = Brushes.LightSlateGray;
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawLine(pen, _title.Location.X, _title.Location.Y + border - 10, _title.Location.X + _title.Width, _title.Location.Y + border - 10);
            e.Graphics.DrawLine(pen, startBtn.Width + 50, border + 20, startBtn.Width + 50, this.Height - 80);
            if (_chosen != null)
            {
                e.Graphics.FillRectangle(b, sportContainer.Location.X + _chosen.Location.X - 2, sportContainer.Location.Y + _chosen.Location.Y - 2, _chosen.Width + 4, _chosen.Height + 4);
            }
        }

        private void numberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ChooseExercise(object sender, EventArgs e)
        {
            if (_chosen == null || _chosen != (Button)sender)
            {
                _chosen = (Button)sender;
                if (_chosen.Name == exercisesBtn[0].Name)
                    Global.CurrentSport = Sports.JumpingJacks;
                else if (_chosen.Name == exercisesBtn[1].Name)
                    Global.CurrentSport = Sports.Running;
                else if (_chosen.Name == exercisesBtn[2].Name)
                    Global.CurrentSport = Sports.PushUp;
                else if (_chosen.Name == exercisesBtn[3].Name)
                    Global.CurrentSport = Sports.Crunch;
                else if (_chosen.Name == exercisesBtn[4].Name)
                    Global.CurrentSport = Sports.TricepsDips;
                else if (_chosen.Name == exercisesBtn[5].Name)
                    Global.CurrentSport = Sports.Squat;
            }
            else
            {
                _chosen = null;
            }
            Invalidate();
        }

        private void StartExercise(object sender, EventArgs e)
        {
            if (_chosen != null)
            {
                Global.exerciseTime = Convert.ToInt32(_exerciseTime.Text);
                Global.ChangePage(Pages.ExercisePage);
            }
            else
            {
                MessageBox.Show("Please select an exercise first", "Error");
            }
        }
    }
}

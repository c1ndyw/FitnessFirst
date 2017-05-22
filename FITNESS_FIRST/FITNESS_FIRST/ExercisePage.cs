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
    public partial class ExercisePage : UserControl
    {
        MainMenuHeader2 header = new MainMenuHeader2();
        Panel drawingPad = new Panel();
        Button _startclock = new Button();
        Button _pauseclock = new Button();
        PictureBox animation = new PictureBox();
        Label instruction = new Label();
        ToolTip hint = new ToolTip();

        int timer = 0;

        // for timer
        Label timerLabel = new Label();
        Font timerFont = new Font(FontFamily.GenericSansSerif, 35, FontStyle.Bold);
        static string hex = "#126391";
        Color timerColor = System.Drawing.ColorTranslator.FromHtml(hex);

        //for animation
        Bitmap animationImage;
        bool currentlyAnimating = false;
        string state = null;

        //for get the right exercise 
        Sports _exerciseName;
        public Sports ExerciseName { get { return _exerciseName; } set { _exerciseName = value; } }
        public string State { get { return state; } set { state = value; } }
        public int Timer { get { return timer; } set { timer = value; } }

        public Sports CurrentSport { get; set; }

        public Button PauseClock { get { return _pauseclock; } set { _pauseclock = value; } }
        public Button StartClock { get { return _startclock; } set { _startclock = value; } }
        public bool IsStrClkShow = true;
        public bool ISPauClkShow = true;

        public ExercisePage()
        {
            InitializeComponent();
            Initialize(Sports.JumpingJacks);
            animation.BackgroundImageLayout = ImageLayout.Zoom;
            PauseClock.Controls.Add(timerLabel);
            drawingPad.Controls.Add(StartClock);
            drawingPad.Controls.Add(PauseClock);
            drawingPad.Controls.Add(animation);
            hint.SetToolTip(StartClock, "Click to start or unpause the exercise");
            hint.SetToolTip(PauseClock, "Click to pause the exercise");
            drawingPad.Controls.Add(instruction);
            Controls.Add(header);
            Controls.Add(drawingPad);
            this.animation.Paint += new PaintEventHandler(Draw);

            ImageAnimator.StopAnimate(animationImage, new EventHandler(OnFrameChanged));
            StartClock.BackgroundImage = FitnessFirst.Properties.Resources.startclock;
            StartClock.Click += new EventHandler(StartTime);

            PauseClock.BackgroundImage = FitnessFirst.Properties.Resources.Running;
            timerLabel.Click += new EventHandler(PauseTime);
        }

        public void Initialize(Sports sport)
        {
            ExerciseName = sport;
            if (ExerciseName == Sports.JumpingJacks)
                // animation.Image = FitnessFirst.Properties.Resources.GIF_jumping_jack;
                animationImage = FitnessFirst.Properties.Resources.JumpingJackAnimation;
            else if (ExerciseName == Sports.Running)
                // animation.Image = FitnessFirst.Properties.Resources.GIF_running;
                animationImage = FitnessFirst.Properties.Resources.RunningAnimation;
            else if (ExerciseName == Sports.PushUp)
                //animation.Image = FitnessFirst.Properties.Resources.GIF_push_up;
                animationImage = FitnessFirst.Properties.Resources.PushUpAnimation;
            else if (ExerciseName == Sports.Crunch)
                // animation.Image = FitnessFirst.Properties.Resources.GIF_crunch;
                animationImage = FitnessFirst.Properties.Resources.CruchAnimation;
            else if (ExerciseName == Sports.TricepsDips)
                // animation.Image = FitnessFirst.Properties.Resources.GIF_triceps_dips;
                animationImage = FitnessFirst.Properties.Resources.TricepsDipsAnimation;
            else if (ExerciseName == Sports.Squat)
                // animation.Image = FitnessFirst.Properties.Resources.GIF_squat;
                animationImage = FitnessFirst.Properties.Resources.SquatAnimation;
            else
                // animation.Image = FitnessFirst.Properties.Resources.GIF_squat;
                animationImage = FitnessFirst.Properties.Resources.SquatAnimation;
            Reset();
        }

        public void Reset()
        {
            StartClock.Show();
            PauseClock.Hide();
            timer1.Stop();
            Timer = Global.exerciseTime;
        }

        public void ReSize()
        {
            header.Width = this.Width;
            header.Height = 100;
            header.Location = new Point(0, 0);
            header.ReSize();

            drawingPad.Width = this.Width;
            drawingPad.Height = this.Height - header.Height;
            drawingPad.Location = new Point(0, header.Height);
            drawingPad.BackColor = Color.White;

            StartClock.Width = 150;
            StartClock.Height = 150;
            StartClock.FlatStyle = FlatStyle.Flat;
            StartClock.FlatAppearance.BorderSize = 0;
            StartClock.BackColor = Color.Transparent;
            StartClock.BackgroundImageLayout = ImageLayout.Zoom;
            StartClock.Cursor = Cursors.Hand;

            StartClock.Location = PauseClock.Location = new Point(this.Width / 2 - StartClock.Width / 2, 30);

            PauseClock.Width = 150;
            PauseClock.Height = 150;
            PauseClock.FlatStyle = FlatStyle.Flat;
            PauseClock.FlatAppearance.BorderSize = 0;
            PauseClock.BackColor = Color.Transparent;
            PauseClock.BackgroundImageLayout = ImageLayout.Zoom;
            PauseClock.Cursor = Cursors.Hand;

            instruction.Font = Global.CustomFont2;
            instruction.Size = new System.Drawing.Size(400, 150);
            instruction.Text = "1. Click the start clock to start the exercise.\n2. Click the running clock to pause the timer.\n3. Back to home will reset the clock.";
            instruction.Location = new Point(StartClock.Location.X + StartClock.Width + 10, StartClock.Location.Y);

            timer1.Interval = 1000;//1s

            timerLabel.Width = 150;
            timerLabel.Height = 170;
            timerLabel.Location = new Point(0, 0);
            timerLabel.BackColor = Color.Transparent;
            timerLabel.ForeColor = timerColor;
            timerLabel.Font = timerFont;
            timerLabel.TextAlign = ContentAlignment.MiddleCenter;

            animation.Width = 400;
            animation.Height = 400;
            animation.Location = new Point(this.Width / 2 - animation.Width / 2, 80 + StartClock.Height);
        }

        public void Draw(object sender, PaintEventArgs g)
        {
            ImageAnimator.UpdateFrames();
            g.Graphics.DrawImage(animationImage, Point.Empty);
        }

        public void AnimateImage()
        {
            if (!currentlyAnimating)
            {
                //Begin the animation only once. 
                ImageAnimator.Animate(animationImage, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }
        //Start the animation and time
        private void StartTime(object sender, EventArgs e)
        {
            Start();
        }

        public void Start()
        {
            //Animate(animation, !IsAnimating(animation));
            ImageAnimator.Animate(animationImage, new EventHandler(this.OnFrameChanged));

            StartClock.Hide();
            PauseClock.Show();
            Invalidate();

            timer1.Start();
            timerLabel.Text = Timer.ToString();
        }

        //Pause the aniamation and time
        private void PauseTime(object sender, EventArgs e)
        {
            Pause();
        }

        public void Pause()
        {
            timer1.Stop();
            PauseClock.Hide();
            StartClock.Show();
            ImageAnimator.StopAnimate(animationImage, new EventHandler(OnFrameChanged));
            Invalidate();
        }

        //call the paint method of the animation
        void OnFrameChanged(object sender, EventArgs e)
        {
            this.animation.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer--;

            if (Timer <= -1)
            {
                timer1.Stop();
                ImageAnimator.StopAnimate(animationImage, new EventHandler(OnFrameChanged));
                MessageBox.Show("Time up!");
                StartClock.Show();
                PauseClock.Hide();
                State = "stop";
                Global.AddExerciseCount();
                if (Global.DefaultAchievements.Count > 0)
                    Global.SynchronizeAchievement();
                Reset();
            }
            else
            {
                timerLabel.Text = Timer.ToString();
            }
        }

        //For unit test
        public void TestTimerTick()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            timer1_Tick(sender, e);
        }


        public void TestStartandPause()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            Start();
            timer1_Tick(sender, e);
            Pause();
        }

        //Another way to solve this problem
        //private static bool IsAnimating(PictureBox box)
        //{
        //    var fi = box.GetType().GetField("currentlyAnimating",
        //        BindingFlags.NonPublic | BindingFlags.Instance);
        //    return (bool)fi.GetValue(box);
        //}
        //private static void Animate(PictureBox box, bool enable)
        //{
        //    var anim = box.GetType().GetMethod("Animate",
        //        BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof(bool) }, null);
        //    anim.Invoke(box, new object[] { enable });
        //}
    }
}

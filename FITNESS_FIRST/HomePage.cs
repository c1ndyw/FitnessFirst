using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            startBtn.Location = new Point(0, 0);
            startBtn.BackColor = Color.CadetBlue;
            sportContainer.BackColor = Color.Coral;
        }

        public void ReSize()
        {
            startBtn.Width = (int)(this.Width * 2 / 5);
            startBtn.Height = this.Height;
            sportContainer.Location = new Point(startBtn.Width, 0);
            sportContainer.Width = (int)(this.Width * 3 / 5);
            sportContainer.Height = this.Height;
            SetButtons();
        }

        public void SetButtons()
        {
            Global.DefaultSport();
            int buttonSize = (int)(sportContainer.Width / 4);
            int row = 0, col = 0;
            for(int i = 0; i<Global.Sports.Count; i++)
            {
                Button b = new Button();
                b.Name = Global.Sports[i];
                b.Location = new Point(col * buttonSize, row * buttonSize);
                b.Width = buttonSize;
                b.Height = buttonSize;
                b.FlatStyle = FlatStyle.Flat;
                col++;
                if (col >= 4)
                {
                    col = 0;
                    row++;
                }
                sportContainer.Controls.Add(b);
            }
        }
    }
}

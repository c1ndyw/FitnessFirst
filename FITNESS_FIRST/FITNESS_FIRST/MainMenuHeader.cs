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
    public partial class MainMenuHeader : UserControl
    {
        Button[] _buttons = new Button[4];

        public MainMenuHeader()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            homeBtn.Name = "home";
            calendarBtn.Name = "calendar";
            graphBtn.Name = "graph";
            settingsBtn.Name = "settings";
            _buttons[0] = homeBtn;
            _buttons[1] = calendarBtn;
            _buttons[2] = graphBtn;
            _buttons[3] = settingsBtn;
        }

        public Button getButton(string buttonName)
        {
            foreach (Button button in _buttons) {
                if (button.Name == buttonName)
                {
                    return button;
                }
            }
            return null;
        }

        public void resize()
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[_buttons.Length - i - 1].Location = new Point(this.Width - (i+1) * Global.ButtonSize - 10, 0);
                _buttons[_buttons.Length - i - 1].Width = Global.ButtonSize;
                _buttons[_buttons.Length - i - 1].Height = Global.ButtonSize;
                _buttons[_buttons.Length - i - 1].FlatStyle = FlatStyle.Flat;
            }
        }
    }
}

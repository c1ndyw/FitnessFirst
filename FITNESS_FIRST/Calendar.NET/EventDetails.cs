using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Calendar.NET
{
    public partial class EventDetails : Form
    {
        public IEvent _event;
        public IEvent _newEvent;
        public Calendar _form;
        public bool update = false;


      //  public _IEvent newEvent = new _IEvent();

        public IEvent Event
        {
            get { return _event; }
            set
            {
                _event = value;
                FillValues();
            }
        }

        public IEvent NewEvent
        {
            get { return _newEvent; }
            set
            {
                _event = value;
                FillValues();
            }
        }

        public EventDetails()
        {
            InitializeComponent();
            PopulateComboBox();
            
        }
        public EventDetails(Calendar form)
        {
            InitializeComponent();
            PopulateComboBox();
           _form= form;

        }

        public void PopulateComboBox()
        {
            cbRecurringFrequency.Items.Add("None");
            cbRecurringFrequency.Items.Add("Custom");
            cbRecurringFrequency.Items.Add("Daily");
            cbRecurringFrequency.Items.Add("Every Monday, Wednesday and Friday");
            cbRecurringFrequency.Items.Add("Every Tuesday and Thursday");
            cbRecurringFrequency.Items.Add("Every Week Day (Mon - Fri)");
            cbRecurringFrequency.Items.Add("Every Weekend (Sat & Sun)");
            cbRecurringFrequency.Items.Add("Every Month");
            cbRecurringFrequency.Items.Add("Every week");
            cbRecurringFrequency.Items.Add("Every year");
        }

        public static RecurringFrequencies StringToRecurringFrequencies(string f)
        {
            RecurringFrequencies retval = RecurringFrequencies.None;

            if (f.Equals("Custom"))
                retval = RecurringFrequencies.Custom;
            if (f.Equals("Daily"))
                retval = RecurringFrequencies.Daily;
            if (f.Equals("Every Monday, Wednesday and Friday") || f.Equals("EveryMonWedFri"))
                retval = RecurringFrequencies.EveryMonWedFri;
            if (f.Equals("Every Tuesday and Thursday") || f.Equals("EveryTueThurs"))
                retval = RecurringFrequencies.EveryTueThurs;
            if (f.Equals("Every Week Day (Mon - Fri)") || f.Equals("EveryWeekday"))
                retval = RecurringFrequencies.EveryWeekday;
            if (f.Equals("Every Weekend (Sat & Sun)") || f.Equals("EveryWeekend"))
                retval = RecurringFrequencies.EveryWeekend;
            if (f.Equals("Every Month") || f.Equals("Monthly"))
                retval = RecurringFrequencies.Monthly;
            if (f.Equals("Every week") || f.Equals("Weekly"))
                retval = RecurringFrequencies.Weekly;
            if (f.Equals("Every year") || f.Equals("Yearly"))
                retval = RecurringFrequencies.Yearly;
            if (f.Equals("None"))
                retval = RecurringFrequencies.None;
            return retval;
        }

        public string RecurringFrequencyToString(RecurringFrequencies f)
        {
            string retval = "";

            switch (f)
            {
                case RecurringFrequencies.Custom:
                    retval = "Custom";
                    break;
                case RecurringFrequencies.Daily:
                    retval = "Daily";
                    break;
                case RecurringFrequencies.EveryMonWedFri:
                    retval = "Every Monday, Wednesday and Friday";
                    break;
                case RecurringFrequencies.EveryTueThurs:
                    retval = "Every Tuesday and Thursday";
                    break;
                case RecurringFrequencies.EveryWeekday:
                    retval = "Every Week Day (Mon - Fri)";
                    break;
                case RecurringFrequencies.EveryWeekend:
                    retval = "Every Weekend (Sat & Sun)";
                    break;
                case RecurringFrequencies.Monthly:
                    retval = "Every Month";
                    break;
                case RecurringFrequencies.None:
                    retval = "None";
                    break;
                case RecurringFrequencies.Weekly:
                    retval = "Every week";
                    break;
                case RecurringFrequencies.Yearly:
                    retval = "Every year";
                    break;
            }
            return retval;
        }

        public void FillValues()
        {
            eventName.Text = _event.EventText;
            startDate.Value = _event.StartDate;
            endDate.Value = _event.EndDate;
            startDate.CustomFormat = _event.IgnoreTimeComponent ? "M/d/yyyy" : "M/d/yyyy h:mm tt";
            endDate.CustomFormat = _event.IgnoreTimeComponent ? "M/d/yyyy" : "M/d/yyyy h:mm tt";
            cbRecurringFrequency.SelectedItem = RecurringFrequencyToString(_event.RecurringFrequency);
            chkThisDayForwardOnly.Enabled = _event.RecurringFrequency != RecurringFrequencies.None;
            //chkEnabled.Checked = _event.Enabled;
            //lblFont.Text = _event.EventFont.FontFamily.Name + " " + _event.EventFont.Size.ToString(CultureInfo.InvariantCulture) + "pt";
            //pnlEventColor.BackColor = _event.EventColor;
            //pnlTextColor.BackColor = _event.EventTextColor;
            //chkIgnoreTimeComponent.Checked = _event.IgnoreTimeComponent;
            //chkEnableTooltip.Checked = _event.TooltipEnabled;

            Text = char.ToUpper(_event.EventText[0]) + _event.EventText.Substring(1) + " Details";

            _newEvent = _event.Clone();
        }

        public void BtnFontClick(object sender, EventArgs e)
        {
            fontDialog1.Font = _newEvent.EventFont;
            DialogResult dr = fontDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                _newEvent.EventFont = fontDialog1.Font;
            }
        }

        public void BtnOkClick(object sender, EventArgs e)
        {
           // newEvent.EventText = txtEventName.Text;
           // _newEvent.Date = dtDate.Value;
            //_newEvent.Enabled = chkEnabled.Checked;
            //_newEvent.RecurringFrequency = StringToRecurringFrequencies(cbRecurringFrequency.SelectedItem.ToString());
            //_newEvent.ThisDayForwardOnly = chkThisDayForwardOnly.Checked;
            //_newEvent.IgnoreTimeComponent = chkIgnoreTimeComponent.Checked;
           // _newEvent.TooltipEnabled = chkEnableTooltip.Checked;
            //DateTime dt = dtDate.va
            if (cbRecurringFrequency.Text == "" || eventName.Text == "") return;
            var exerciseEvent = new CustomEvent
            {
                StartDate = startDate.Value,
                EndDate = endDate.Value,
                RecurringFrequency = StringToRecurringFrequencies(cbRecurringFrequency.SelectedItem.ToString()),
                EventLengthInHours = 1,
                Alert = 1,
                EventText = eventName.Text,
                EventFont = new Font(FontFamily.GenericSansSerif, 12.0f, FontStyle.Regular),
                Days = new List<DayOfWeek>()
            };
            Calendar.initDays(exerciseEvent);
            _newEvent = exerciseEvent;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void PnlEventColorDoubleClick(object sender, EventArgs e)
        {
            colorDialog1.Color = _newEvent.EventColor;
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //.BackColor = colorDialog1.Color;
                _newEvent.EventColor = colorDialog1.Color;
            }
        }

        private void PnlTextColorDoubleClick(object sender, EventArgs e)
        {
            colorDialog1.Color = _newEvent.EventColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
               // pnlTextColor.BackColor = colorDialog1.Color;
                _newEvent.EventTextColor = colorDialog1.Color;
            }
        }

        private void ChkIgnoreTimeComponentCheckedChanged(object sender, EventArgs e)
        {
           // dtDate.CustomFormat = chkIgnoreTimeComponent.Checked ? "M/d/yyyy" : "M/d/yyyy h:mm tt";
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

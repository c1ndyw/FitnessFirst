using System;
using System.Collections.Generic;
using System.Drawing;

namespace Calendar.NET
{
    /// <summary>
    /// A custom or user-defined event
    /// </summary>
    public class CustomEvent : IEvent
    {
        public int Rank
        {
            get;
            set;
        }

        public int Alert
        {
            get;
            set;
        }

        public List<DayOfWeek> Days
        {
            get;
            set;
        }

        public float EventLengthInHours
        {
            get;
            set;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public CustomRecurringFrequenciesHandler CustomRecurringFunction
        {
            get;
            set;
        }

        public bool IgnoreTimeComponent
        {
            get;
            set;
        }

        public bool ReadOnlyEvent
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }

        public DateTime EndDate
        {
            get;
            set;
        }

        public Color EventColor
        {
            get;
            set;
        }

        public Font EventFont
        {
            get;
            set;
        }

        public string EventText
        {
            get;
            set;
        }

        public Color EventTextColor
        {
            get;
            set;
        }

        public RecurringFrequencies RecurringFrequency
        {
            get;
            set;
        }

        public bool TooltipEnabled
        {
            get;
            set;
        }

        public bool ThisDayForwardOnly
        {
            get;
            set;
        }

        /// <summary>
        /// CustomEvent Constructor
        /// </summary>
        public CustomEvent()
        {
            int color1 = new Random().Next(40, 210);
            int color2 = new Random().Next(40, 210);
            EventColor = Color.FromArgb(255, color1, color2);
            EventFont = new Font("Arial", 8, FontStyle.Bold);
            EventTextColor = Color.FromArgb(0, 0, 0);
            Rank = 2;
            EventLengthInHours = 1.0f;
            ReadOnlyEvent = false;
            Enabled = true;
            IgnoreTimeComponent = false;
            TooltipEnabled = true;
            ThisDayForwardOnly = true;
            RecurringFrequency = RecurringFrequencies.None;
        }

        public IEvent Clone()
        {
            return new CustomEvent
            {
                CustomRecurringFunction = CustomRecurringFunction,
                StartDate = StartDate,
                EndDate = EndDate,
                Alert = Alert,
                Enabled = Enabled,
                EventColor = EventColor,
                EventFont = EventFont,
                EventText = EventText,
                EventTextColor = EventTextColor,
                IgnoreTimeComponent = IgnoreTimeComponent,
                Rank = Rank,
                ReadOnlyEvent = ReadOnlyEvent,
                RecurringFrequency = RecurringFrequency,
                ThisDayForwardOnly = ThisDayForwardOnly,
                EventLengthInHours = EventLengthInHours,
                TooltipEnabled = TooltipEnabled
            };
        }
    }
}

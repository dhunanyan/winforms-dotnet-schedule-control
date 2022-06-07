using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCalendar.CustomControls
{


    public partial class CustomSchedule : UserControl
    {

        private string[] daysOfWeek =  new string[]{ "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        private string[,] mounth = new string[6, 7] {
            { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" },
            { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" },
            { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" },
            { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" },
            { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" },
            { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" }};
        int displayMonth = 0;
        int displayYear = 0;
        public CustomSchedule()
        {
            InitializeComponent();
            displayMonth = GetCurrentMonth();
            displayYear = GetCurrentYear();
            GenerateCurrentMonthDays(displayMonth, displayYear);
        }

        private string GetCurrentDate()
        {
            return DateTime.Now.ToString().Split(' ')[0];
        }

        private int GetCurrentYear()
        {
            return int.Parse(GetCurrentDate().ToString().Split('/')[2].Split(' ')[0]);
        }

        private int GetCurrentMonth()
        {
            return int.Parse(GetCurrentDate().ToString().Split('/')[0]);
        }

        private int GetCurrentDay()
        {
            return int.Parse(GetCurrentDate().ToString().Split('/')[1]);
        }

        private int GetCurrentMonthDaysNumber(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        private void InitializeCurrentMOnthDays()
        {
            for (int i = 0; i < 42; i++)
            {
                Button currentDayButton = (Button)flowLayoutPanelDays.Controls[i];
                currentDayButton.Text = i.ToString();
                currentDayButton.Enabled = true;
                currentDayButton.BackColor = Color.FromArgb(46, 46, 46);
            }
        }

        private void GenerateCurrentMonthDays(int month, int year)
        {
            string currentMonthFirstDayOfWeek = DateTime.Parse($"{month}/{1}/{year}").DayOfWeek.ToString();
            int firstDayOfMonthIndex = Array.IndexOf(daysOfWeek, currentMonthFirstDayOfWeek);
            int dayCounter = 1;
            for (int i = 0; i < 42; i++)
            {
                Button currentDayButton = (Button)flowLayoutPanelDays.Controls[i];
                if (i < firstDayOfMonthIndex || i > GetCurrentMonthDaysNumber(year, month) + firstDayOfMonthIndex - 1)
                {
                    currentDayButton.Text = null;
                    currentDayButton.Enabled = false;
                    currentDayButton.BackColor = Color.FromArgb(80, 46, 46, 46);
                }
                else if(dayCounter <= GetCurrentMonthDaysNumber(year, month))
                {
                    currentDayButton.Text = dayCounter.ToString();
                    currentDayButton.Enabled = true;
                    currentDayButton.BackColor = Color.FromArgb(46, 46, 46);
                    dayCounter++;
                }
            }
        }
        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            if (displayMonth < 1)
            {
                displayMonth = 12;
                displayYear--;
            }
            else
            {
                displayYear--;
            }
            InitializeCurrentMOnthDays();
            GenerateCurrentMonthDays(displayMonth, displayYear);
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            if (displayMonth > 12)
            {
                displayMonth = 1;
                displayYear++;
            }
            else
            {
                displayYear++;
            }
            InitializeCurrentMOnthDays();
            GenerateCurrentMonthDays(displayMonth, displayYear);
        }
    }
}

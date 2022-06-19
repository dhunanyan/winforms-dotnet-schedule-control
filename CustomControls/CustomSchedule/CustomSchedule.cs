using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCalendar.CustomControls.CustomSchedule
{


    public partial class CustomSchedule : UserControl
    {
        public Dictionary<string, List<CustomScheduleEvent>> AllEvents { get; set; } = new Dictionary<string, List<CustomScheduleEvent>>();

        public DateTime Time {get; set;} = DateTime.Now;

        private string[] daysOfWeek =  new string[]{ 
            "Sunday", 
            "Monday", 
            "Tuesday", 
            "Wednesday", 
            "Thursday", 
            "Friday", 
            "Saturday" 
        };
        int displayMonth = 0;
        int displayYear = 0;
        bool isWeekDisplayed = false;
        int counter = 0;

        public CustomSchedule()
        {
            InitializeComponent();
            displayMonth = GetCurrentMonth();
            displayYear = GetCurrentYear();
            GenerateCurrentMonthDays(displayMonth, displayYear);
            SetMonthYear(GetCurrentMonth(), GetCurrentYear());
            InitializeTimer();

            Console.WriteLine(DateTime.Now.Second * 1000 + DateTime.Now.Millisecond);
            Console.WriteLine(DateTime.Now.Millisecond);
        }

        private string GetCurrentDate()
        {
            return DateTime.Now.ToString().Split(' ')[0];
        }

        private string GetCurrentDate(int day, int month, int year)
        {
            return DateTime.Parse($"{month}/{day}/{year}").ToString().Split(' ')[0];
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

        private void SetMonthYear(int month, int year)
        {
            labelMonthYear.Text = $"{DateTime.Parse(GetCurrentDate(1, month, year)):MMMM} {year}";
        }

        public int GetCurrentMonthDaysNumber(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        private void GenerateCurrentMonthDays(int month, int year)
        {
            string currentMonthFirstDayOfWeek = DateTime.Parse(GetCurrentDate(1, month, year)).DayOfWeek.ToString();
            int firstDayOfMonthIndex = Array.IndexOf(daysOfWeek, currentMonthFirstDayOfWeek);
            int dayCounter = 1;
            int width = 10;
            int height = 10;
            flowLayoutPanelDays.Controls.Clear();
            for (int i = 0; i < 42; i++)
            {
                CustomScheduleDay.CustomScheduleDay currentDayPanel = new CustomScheduleDay.CustomScheduleDay(this, i, width, height, dayCounter, $"{dayCounter}/{month}/{year}");
                if (i < firstDayOfMonthIndex || i > GetCurrentMonthDaysNumber(year, month) + firstDayOfMonthIndex - 1)
                {
                    currentDayPanel.Text = null;
                    currentDayPanel.Enabled = false;
                    currentDayPanel.BackColor = Color.FromArgb(80, 46, 46, 46);
                    currentDayPanel.Controls.Clear();
                    currentDayPanel.Tag = 0;
                }
                else if(dayCounter <= GetCurrentMonthDaysNumber(year, month))
                {
                    currentDayPanel.Tag = $"{dayCounter}/{month}/{year}";
                    currentDayPanel.Enabled = true;
                    currentDayPanel.BackColor = (month == GetCurrentMonth() && year == GetCurrentYear() && dayCounter == GetCurrentDay()) ? Color.FromArgb(72, 72, 72) : Color.FromArgb(46, 46, 46);
                    currentDayPanel.Click += new EventHandler(CurrentDayButton_Click);
                    currentDayPanel.MouseEnter += new EventHandler(CurrentDayButton_MouseEnter);
                    currentDayPanel.MouseLeave += new EventHandler(CurrentDayButton_MouseLeave);
                    dayCounter++;
                }

                if(width >= 610)
                {
                    height += 100;
                    width = 10;
                }
                else
                {
                    width += 100;
                }

                flowLayoutPanelDays.Controls.Add(currentDayPanel);
            }
        }

        private void FillMonthEvents()
        {
            foreach(Control c in flowLayoutPanelDays.Controls)
            {
                if(c is CustomScheduleDay.CustomScheduleDay && c.Tag.ToString() != "0")
                {
                    string currentKey = c.Tag.ToString();
                    if (!AllEvents.Keys.Contains(currentKey))
                    {
                        continue;
                    }

                    foreach(CustomScheduleEvent currentEvent in AllEvents[currentKey])
                    {
                        Button addedEvent = new Button()
                        {
                            Text = "",
                            Size = new Size(12, 12),
                            Margin = new Padding(1),
                            FlatStyle = FlatStyle.Flat,
                            Cursor = Cursors.Hand,
                            Location = new Point(0, 0),
                            Name = $"{currentEvent.Date}/{currentEvent.TimeFrom}-{currentEvent.TimeTo}",
                            UseVisualStyleBackColor = false
                        };

                        addedEvent.FlatAppearance.BorderSize = 1;
                        addedEvent.FlatAppearance.BorderColor = Color.FromArgb(92, 92, 92);


                        if (currentEvent.Priority == "High")
                        {
                            addedEvent.BackColor = Color.FromArgb(222, 23, 56);
                        }
                        else if (currentEvent.Priority == "Medium")
                        {
                            addedEvent.BackColor = Color.FromArgb(247, 222, 58);

                        }
                        else if (currentEvent.Priority == "Low")
                        {
                            addedEvent.BackColor = Color.FromArgb(118, 187, 104);
                        }
                        else
                        {
                            addedEvent.BackColor = Color.FromArgb(72, 97, 163);
                        }

                        ((FlowLayoutPanel)c.Controls.Find($"flowLayoutPanelDay{c.Name.Split('l')[1]}", true)[0]).Controls.Add(addedEvent);
                    }
                }
            }
        }
        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            if (displayMonth < 2)
            {
                displayMonth = 12;
                displayYear--;
            }
            else
            {
                displayMonth--;
            }

            GenerateCurrentMonthDays(displayMonth, displayYear);
            SetMonthYear(displayMonth, displayYear);
            FillMonthEvents();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            if (displayMonth > 11)
            {
                displayMonth = 1;
                displayYear++;
            }
            else
            {
                displayMonth++;
            }
            GenerateCurrentMonthDays(displayMonth, displayYear);
            SetMonthYear(displayMonth, displayYear);
            FillMonthEvents();
        }

        private void CurrentDayButton_Click(object sender, EventArgs e)
        {
            CustomScheduleDay.CustomScheduleDay currentDayPanel = (CustomScheduleDay.CustomScheduleDay)sender;
            Form formBackground = new Form();

            try
            {
                using (FormDayPopup uu = new FormDayPopup(currentDayPanel))
                {
                    //formBackground.StartPosition = FormStartPosition.Manual;
                    //formBackground.FormBorderStyle = FormBorderStyle.None;
                    //formBackground.Opacity = .50d;
                    //formBackground.BackColor = Color.Black;
                    //formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    //formBackground.Location = Location;
                    //formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                    uu.StartPosition = FormStartPosition.CenterScreen;
                    //uu.Owner = formBackground;
                    uu.GenerateDateTextBox(currentDayPanel.Tag.ToString());
                    uu.ShowDialog();
                    //currentPopup = uu;

                    formBackground.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CurrentDayButton_MouseEnter(object sender, EventArgs e)
        {
            Panel currentDayPanel = (Panel)(sender);
            if(currentDayPanel.Tag.ToString() == $"{GetCurrentDay()}/{GetCurrentMonth()}/{GetCurrentYear()}")
            {
                currentDayPanel.BackColor = Color.FromArgb(82, 82, 82);
            }
            else
            {
                currentDayPanel.BackColor = Color.FromArgb(52, 52, 52);
            }
        }

        private void CurrentDayButton_MouseLeave(object sender, EventArgs e)
        {
            Panel currentDayPanel = (Panel)(sender);
            if (currentDayPanel.Tag.ToString() == $"{GetCurrentDay()}/{GetCurrentMonth()}/{GetCurrentYear()}")
            {
                currentDayPanel.BackColor = Color.FromArgb(72, 72, 72);
            }
            else
            {
                currentDayPanel.BackColor = Color.FromArgb(46, 46, 46);
            }
        }

        private void GenereatePanelTime()
        {
            Panel panelTime = new Panel();

            panelTime.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            panelTime.Location = new Point(5, 5);
            panelTime.Margin = new Padding(0);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(100, 600);
            flowLayoutPanelDays.Controls.Add(panelTime);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            isWeekDisplayed = !isWeekDisplayed;

            flowLayoutPanelDays.Controls.Clear();
            if (isWeekDisplayed)
            {
                currentButton.Text = "Display Month";

                labelSun.Text = "Time";
                labelSun.BackColor = Color.FromArgb(46, 46, 46);

                GenereatePanelTime();
            }
            else
            {
                currentButton.Text = "Display Week";

                labelSun.Text = "Sun";
                labelSun.BackColor = Color.FromArgb(29, 28, 29);

                displayMonth = GetCurrentMonth();
                displayYear = GetCurrentYear();
                GenerateCurrentMonthDays(displayMonth, displayYear);
                SetMonthYear(GetCurrentMonth(), GetCurrentYear());
            }

            FillMonthEvents();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.Minute);
            if ((DateTime.Now.Minute < 15) && (counter == 0))
            {
                counter++;
                timer1.Interval = (15 - DateTime.Now.Minute) * 60 * 1000;
            }
            else if ((DateTime.Now.Minute > 45) && (counter == 0))
            {
                timer1.Interval = (DateTime.Now.Minute - 30) * 60 * 1000;
                counter++;
            }

            if ((DateTime.Now.Minute > 15) && (DateTime.Now.Minute < 45) && (counter == 0))
            {
                timer1.Interval = (45 - DateTime.Now.Minute) * 60 * 1000;
                counter++;
            }

            if ((DateTime.Now.Minute == 15 || DateTime.Now.Minute == 45) && (counter == 1))
            {
                timer1.Interval = 1000 * 60 * 30;
                counter++;
                MessageBox.Show($"It's: {DateTime.Now}, Minutes: {DateTime.Now.Minute}", "Good job", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public FlowLayoutPanel flowLayoutPanelDays;
        public FlowLayoutPanel flowLayoutPanelMain;
    }
}

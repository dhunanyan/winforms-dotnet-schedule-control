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

        public DateTime Time { get; set; } = DateTime.Now;

        private string[] daysOfWeek = new string[]{
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
        int displayDay = 0;
        public bool IsWeekDisplayed { get; set; } = false;
        public int counter = 0;

        public CustomSchedule()
        {
            InitializeComponent();
            displayDay = GetCurrentDay();
            displayMonth = GetCurrentMonth();
            displayYear = GetCurrentYear();
            GenerateCurrentMonthOrWeek(displayDay, displayMonth, displayYear, IsWeekDisplayed);
            SetMonthYear(GetCurrentDay(), GetCurrentMonth(), GetCurrentYear());
            InitializeTimer();
            GenerateTimePanel(IsWeekDisplayed);

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


        private void SetMonthYear(int day, int month, int year)
        {
            labelMonthYear.Text = $"{DateTime.Parse(GetCurrentDate(day, month, year)):MMMM} {year}";
        }

        public int GetCurrentMonthDaysNumber(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        private List<string> GetAllEventsKeys()
        {
            List<string> AllEventsKeys = (List<string>)AllEvents.Keys.ToList();
            AllEventsKeys.Sort();

            return AllEventsKeys;
        }

        public string ConvertDateWithZeros(string date)
        {
            string[] array = date.Split('/');

            if (int.Parse(array[0]) < 9)
            {
                array[0] = "0" + array[0];

            }

            if (int.Parse(array[1]) < 9)
            {
                array[1] = "0" + array[1];
            }
            string result = $"{array[0]}/{array[1]}/{array[2]}";

            return result;
        }

        public DateTime ConvertStringToDateTime(string date)
        {
            string[] array = date.Split('/');

            string result = $"{array[1]}/{array[0]}/{array[2]}";

            return DateTime.Parse(result);
        }

        private string SwithMonthAndDayInDate(string date)
        {
            string[] array = date.Split('/');

            string result = $"{int.Parse(array[1])}/{int.Parse(array[0])}/{array[2]}";

            return result;
        }

        private int GetFirstDayOfCurrentWeek(){

            int sunday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek).Day; 
            return sunday;
        }

        private void GenerateCurrentMonthOrWeek(int day, int month, int year, bool isWeekDisplay)
        {
            flowLayoutPanelDays.Controls.Clear();

            if (!isWeekDisplay) {
                GenerateCurrentMonthDays(day, month, year, isWeekDisplay);
            }
            else
            {
                GenerateCurrentWeekDays(day, month, year, isWeekDisplay);
            }
        }

        private void GenerateTimePanel(bool isWeekDisplay)
        {
            flowLayoutPanelTimeLabels.Controls.Clear();
            int labelTimeElementHeight = 5;

            for (int i = 0; i < (isWeekDisplay ? 24 : 6); i++)
            {
                Label labelTimeElement = new Label
                {
                    BackColor = Color.FromArgb(46, 46, 46),
                    Font = new Font("Tw Cen MT Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 238),
                    ForeColor = Color.Gainsboro,
                    Location = new Point(0, labelTimeElementHeight),
                    Margin = new Padding(0),
                    Name = $"labelTime{i + 1}",
                    Size = new Size(70, isWeekDisplay ? 25 : 600 / 6),
                    Text = isWeekDisplay ? (i + 1 >= 12 ? $"{i + 1} PM" : $"{i + 1} AM") : $"Week {i + 1}",
                    TextAlign = ContentAlignment.MiddleCenter
                };

                flowLayoutPanelTimeLabels.Controls.Add(labelTimeElement);

                labelTimeElementHeight += isWeekDisplay ? 25 : 600 / 6;
            }
        }

        public int GetEventStartOrAnd(string time)
        {
            if(time.Split(':')[1] == "30")
            {
                return 610 / 24 * int.Parse(time.Split(':')[0]) + (25 / 2);
            }
            else
            {
                return 610 / 24 * int.Parse(time.Split(':')[0]);
            }
            
        }

        private void FillMonthEvents()
        {
            foreach(CustomScheduleDay.CustomScheduleDay c in flowLayoutPanelDays.Controls)
            {
                if(c is CustomScheduleDay.CustomScheduleDay && c.Tag.ToString() != "0")
                {
                    string currentKey = c.Tag.ToString();
                    if (!AllEvents.Keys.Contains(currentKey))
                    {
                        continue;
                    }

                    foreach (CustomScheduleEvent currentEvent in AllEvents[currentKey])
                    {
                        Button addedEvent = new Button();
                        addedEvent.Font = new Font("Microsoft JhengHei Light", IsWeekDisplayed ? 8F : 4.5F, FontStyle.Bold);
                        addedEvent.ForeColor = Color.FromArgb(64, 64, 64);
                        addedEvent.Text = IsWeekDisplayed ? $"{currentEvent.Title}\r\n{currentEvent.TimeFrom}-{currentEvent.TimeTo}" : (currentEvent.Title.Length > 7 ? currentEvent.Title.Substring(0, 7) + "..." : currentEvent.Title);
                        addedEvent.Size = IsWeekDisplayed ? new Size(86, GetEventStartOrAnd(currentEvent.TimeTo == "00:00" ? "24:00" : currentEvent.TimeTo) - GetEventStartOrAnd(currentEvent.TimeFrom)) : new Size(68, 16);
                        addedEvent.Margin = new Padding(1);
                        addedEvent.Padding = new Padding(0);
                        addedEvent.FlatStyle = FlatStyle.Flat;
                        addedEvent.Cursor = Cursors.Hand;
                        addedEvent.Tag = Array.IndexOf(AllEvents[currentKey].ToArray(), currentEvent);
                        addedEvent.Location = IsWeekDisplayed ? new Point(0, GetEventStartOrAnd(currentEvent.TimeFrom)) : new Point(0, 20 * Array.IndexOf(AllEvents[currentKey].ToArray(), currentEvent));
                        addedEvent.Name = $"{currentEvent.Date} {currentEvent.TimeFrom}-{currentEvent.TimeTo}";
                        addedEvent.UseVisualStyleBackColor = false;
                        addedEvent.Enabled = false;
                        addedEvent.FlatAppearance.BorderSize = 1;
                        addedEvent.TextAlign = ContentAlignment.TopLeft;
                        currentEvent.CurrentEvent = addedEvent;

                        if (currentEvent.Priority == "Yellow")
                        {
                            addedEvent.BackColor = Color.FromArgb(190, 253, 238, 101);
                            addedEvent.FlatAppearance.BorderColor = Color.FromArgb(253, 227, 0);
                        }
                        else if(currentEvent.Priority == "Green")
                        {
                            addedEvent.BackColor = Color.FromArgb(190, 82, 206, 144);
                            addedEvent.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 86);
                        }
                        else if(currentEvent.Priority == "Orange")
                        {
                            addedEvent.BackColor = Color.FromArgb(190, 232, 130, 93);
                            addedEvent.FlatAppearance.BorderColor = Color.FromArgb(218, 59, 1);
                        }
                        else if (currentEvent.Priority == "Blue")
                        {
                            addedEvent.BackColor = Color.FromArgb(190, 92, 169, 229);
                            addedEvent.FlatAppearance.BorderColor = Color.FromArgb(0, 120, 212);
                        }
                        else if (currentEvent.Priority == "Red")
                        {
                            addedEvent.BackColor = Color.FromArgb(190, 220, 98, 109);
                            addedEvent.FlatAppearance.BorderColor = Color.FromArgb(197, 15, 31);
                        }
                        else
                        {
                            addedEvent.BackColor = Color.FromArgb(90, 177, 170, 235);
                            addedEvent.FlatAppearance.BorderColor = Color.FromArgb(131, 120, 222);
                        }

                        ((Panel)c.Controls.Find($"panelInnerEvents{c.Name.Split('l')[1]}", true)[0]).Controls.Add(addedEvent);


                        if (Array.IndexOf(AllEvents[currentKey].ToArray(), currentEvent) > 2 && !IsWeekDisplayed)
                        {
                            foreach(Button ev in ((Panel)c.Controls.Find($"panelInnerEvents{c.Name.Split('l')[1]}", true)[0]).Controls)
                            {
                                if (int.Parse(ev.Tag.ToString()) >= 2)
                                {
                                    ev.Visible = false;
                                }
                            }

                            c.infoButton.Visible = true;
                            c.infoButton.Text = "+" + (Array.IndexOf(AllEvents[currentKey].ToArray(), currentEvent) - 1).ToString();
                            c.infoButton.ForeColor = Color.FromArgb(241, 241, 241);
                        }

                        c.currentDayEventsCount = currentEvent.caller.caller.currentDayEventsCount;
                        ((Panel)c.Controls.Find($"panelInnerEvents{c.Name.Split('l')[1]}", true)[0]).Controls.SetChildIndex(addedEvent, AllEvents[currentKey].Count() - Array.IndexOf(AllEvents[currentKey].ToArray(), currentEvent));
                    }
                }
            }
        }

        private void GenerateCurrentMonthDays(int day, int month, int year, bool isWeekDisplay)
        {

            string currentMonthFirstDayOfWeek = DateTime.Parse(GetCurrentDate(1, month, year)).DayOfWeek.ToString();
            int firstDayOfMonthIndex = Array.IndexOf(daysOfWeek, currentMonthFirstDayOfWeek);
            int dayCounter = 1;
            int width = 10;
            int height = 10;
            for (int i = 0; i < 42; i++)
            {
                CustomScheduleDay.CustomScheduleDay currentDayPanel = new CustomScheduleDay.CustomScheduleDay(this, i, width, height, dayCounter, $"{dayCounter}/{month}/{year}", isWeekDisplay);
                if (i < firstDayOfMonthIndex || i > GetCurrentMonthDaysNumber(year, month) + firstDayOfMonthIndex - 1)
                {
                    currentDayPanel.Text = null;
                    currentDayPanel.Enabled = false;
                    currentDayPanel.BackColor = Color.FromArgb(80, 46, 46, 46);
                    currentDayPanel.Controls.Clear();
                    currentDayPanel.Tag = 0;
                }
                else if (dayCounter <= GetCurrentMonthDaysNumber(year, month))
                {
                    currentDayPanel.Tag = ConvertDateWithZeros($"{dayCounter}/{month}/{year}");
                    currentDayPanel.Enabled = true;
                    currentDayPanel.BackColor = (month == GetCurrentMonth() && year == GetCurrentYear() && dayCounter == GetCurrentDay()) ? Color.FromArgb(72, 72, 72) : Color.FromArgb(46, 46, 46);
                    currentDayPanel.Click += new EventHandler(CurrentDayButton_Click);
                    currentDayPanel.MouseEnter += new EventHandler(CurrentDayButton_MouseEnter);
                    currentDayPanel.MouseLeave += new EventHandler(CurrentDayButton_MouseLeave);
                    currentDayPanel.currentDayEventsCount = AllEvents.Keys.Contains(currentDayPanel.Tag.ToString()) ?  AllEvents[currentDayPanel.Tag.ToString()].ToList().Count() - 1 : 0;

                    dayCounter++;
                }

                if (width >= 610)
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

        private void GenerateCurrentWeekDays(int day, int month, int year, bool isWeekDisplay)
        {
            int startDay = day;

            if (day == GetCurrentDay() && month == GetCurrentMonth() && year == GetCurrentYear())
            {
                startDay = GetFirstDayOfCurrentWeek();
            }

            displayDay = startDay;

            int width = 10;
            int height = 610;

            for (int i = 0; i < 7; i++)
            {
                if (startDay > GetCurrentMonthDaysNumber(year, month))
                {
                    startDay = 1;
                }

                CustomScheduleDay.CustomScheduleDay currentDayPanel = new CustomScheduleDay.CustomScheduleDay(this, i, width, height, startDay, $"{startDay}/{month}/{year}", isWeekDisplay);
                currentDayPanel.Tag = ConvertDateWithZeros($"{startDay}/{month}/{year}");
                currentDayPanel.Enabled = true;
                currentDayPanel.BackColor = (month == GetCurrentMonth() && year == GetCurrentYear() && startDay == GetCurrentDay()) ? Color.FromArgb(72, 72, 72) : Color.FromArgb(46, 46, 46);
                currentDayPanel.Click += new EventHandler(CurrentDayButton_Click);
                currentDayPanel.MouseEnter += new EventHandler(CurrentDayButton_MouseEnter);
                currentDayPanel.MouseLeave += new EventHandler(CurrentDayButton_MouseLeave);
                currentDayPanel.currentDayEventsCount = AllEvents.Keys.Contains(currentDayPanel.Tag.ToString()) ? AllEvents[currentDayPanel.Tag.ToString()].ToList().Count() - 1 : 0;

                flowLayoutPanelDays.Controls.Add(currentDayPanel);

                startDay++;
                width += 10;
            }
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            if (!IsWeekDisplayed)
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

                GenerateCurrentMonthOrWeek(displayDay, displayMonth, displayYear, IsWeekDisplayed);
                SetMonthYear(displayDay, displayMonth, displayYear);
            }
            else
            {
                displayDay -= 7;
                if (displayDay < 1)
                {
                    displayMonth--;
                    displayDay = GetCurrentMonthDaysNumber(displayYear, displayMonth) + displayDay;
                }

                if (displayMonth < 2)
                {
                    displayMonth = 12;
                    displayYear--;
                }

                GenerateCurrentMonthOrWeek(displayDay, displayMonth, displayYear, IsWeekDisplayed);
                SetMonthYear(displayDay, displayMonth, displayYear);
            }

            FillMonthEvents();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            if (!IsWeekDisplayed)
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
                GenerateCurrentMonthOrWeek(1, displayMonth, displayYear, IsWeekDisplayed);
                SetMonthYear(displayDay, displayMonth, displayYear);
            }
            else
            {
                displayDay += 7;
                if (displayDay > GetCurrentMonthDaysNumber(displayYear, displayMonth))
                {
                    displayDay -= GetCurrentMonthDaysNumber(displayYear, displayMonth);
                    displayMonth++;
                }

                if (displayMonth > 11)
                {
                    displayMonth = 1;
                    displayYear++;
                }

                GenerateCurrentMonthOrWeek(displayDay, displayMonth, displayYear, IsWeekDisplayed);
                SetMonthYear(displayDay, displayMonth, displayYear);
            }

            FillMonthEvents();
        }

        public void CurrentDayButton_Click(object sender, EventArgs e)
        {
            CustomScheduleDay.CustomScheduleDay currentDayPanel = (CustomScheduleDay.CustomScheduleDay)sender;
            Form formBackground = new Form();

            try
            {
                using (CustomScheduleDayPopup uu = new CustomScheduleDayPopup(currentDayPanel))
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

        public void CurrentDayButton_MouseEnter(object sender, EventArgs e)
        {
            Panel currentDayPanel = (Panel)(sender);
            if(currentDayPanel.Tag.ToString() == ConvertDateWithZeros($"{GetCurrentDay()}/{GetCurrentMonth()}/{GetCurrentYear()}"))
            {
                currentDayPanel.BackColor = Color.FromArgb(82, 82, 82);
            }
            else
            {
                currentDayPanel.BackColor = Color.FromArgb(52, 52, 52);
            }
        }

        public void CurrentDayButton_MouseLeave(object sender, EventArgs e)
        {
            Panel currentDayPanel = (Panel)(sender);
            if (currentDayPanel.Tag.ToString() == ConvertDateWithZeros($"{GetCurrentDay()}/{GetCurrentMonth()}/{GetCurrentYear()}"))
            {
                currentDayPanel.BackColor = Color.FromArgb(72, 72, 72);
            }
            else
            {
                currentDayPanel.BackColor = Color.FromArgb(46, 46, 46);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            IsWeekDisplayed = !IsWeekDisplayed;

            displayDay = GetFirstDayOfCurrentWeek();
            displayMonth = GetCurrentMonth();
            displayYear = GetCurrentYear();

            GenerateCurrentMonthOrWeek(displayDay, displayMonth, displayYear, IsWeekDisplayed);
            SetMonthYear(GetCurrentDay(), GetCurrentMonth(), GetCurrentYear());
            GenerateTimePanel(IsWeekDisplayed);

            FillMonthEvents();
            DisabledPastEvents();
        }

        public void DisabledPastEvents()
        {
            foreach (string key in GetAllEventsKeys().ToList())
            {
                if ((String.Compare(DateTime.Now.Date.ToString().Split(' ')[0], SwithMonthAndDayInDate(key)) >= 0) && (DateTime.Now.Date.ToString().Split(' ')[0] != SwithMonthAndDayInDate(key)))
                {
                    foreach (CustomScheduleEvent eventInList in AllEvents[key].ToList())
                    {
                        eventInList.CurrentEvent.Enabled = false;
                    }
                }
            }
        }

        private CustomScheduleEvent GetFirstEnabledEvent(string key)
        {
            if((AllEvents.Count <= 0) || (!AllEvents.Keys.Contains(key)))
            {
                return null;
            }

            return AllEvents[ConvertDateWithZeros(SwithMonthAndDayInDate(GetCurrentDate()))].ToList().Where(ev => ev.CurrentEvent.Enabled == true).FirstOrDefault();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CustomScheduleEvent eventToRemind = GetFirstEnabledEvent(ConvertDateWithZeros(SwithMonthAndDayInDate(GetCurrentDate())));

            DisabledPastEvents();

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

                //CustomScheduleEvent eventToRemind = GetFirstEnabledEvent();

                if((eventToRemind != null) && (AllEvents.Keys != null) && (eventToRemind.TimeFrom.Split(':')[1] == DateTime.Now.AddMinutes(15).ToString().Split(' ')[1].Split(':')[1]))
                {

                    MessageBox.Show(
                    $"Upcoming Event: {eventToRemind.Title} \n" +
                    $"Date: {eventToRemind.Date} {eventToRemind.TimeFrom}-{eventToRemind.TimeTo} \n" +
                    $"Priority Level: {eventToRemind.Priority}", 
                    "Good job", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                }
            }
        }

        public FlowLayoutPanel flowLayoutPanelDays;
        public FlowLayoutPanel flowLayoutPanelMain;
        public Timer timer1;
    }
}

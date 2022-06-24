using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCalendar.CustomControls.CustomScheduleDay
{
    public class CustomScheduleDay : Panel
    {
        public CustomSchedule.CustomSchedule caller;

        public int currentDayEventsCount;
        public string Date { get; set; }

        public Button infoButton;

        public CustomScheduleDay(CustomSchedule.CustomSchedule caller, int i, int width, int height, int dayCounter, string date, bool isWeekDisplay)
        {
            IntializeDay(i, width, height, dayCounter, isWeekDisplay);
            this.caller = caller;
            Date = date;
        }


        private Button GenerateInfoButton()
        {
            infoButton = new Button();
            infoButton.Font = new Font("Microsoft JhengHei Light", 4.5F, FontStyle.Bold);
            infoButton.Text = "";
            infoButton.Size = new Size(68, 16);
            infoButton.Margin = new Padding(1);
            infoButton.Padding = new Padding(0);
            infoButton.FlatStyle = FlatStyle.Flat;
            infoButton.Location = new Point(0, 40);
            infoButton.Name = $"infoButton";
            infoButton.Enabled = false;
            infoButton.Visible = false;
            infoButton.Tag = -1;
            infoButton.FlatAppearance.BorderSize = 1;
            infoButton.TextAlign = ContentAlignment.TopCenter;
            infoButton.BackColor = Color.FromArgb(94, 94, 94);
            infoButton.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            infoButton.ForeColor = Color.FromArgb(241, 241, 241);

            return infoButton;
        }

        public void IntializeDay(int i, int width, int height, int dayCounter, bool isWeekDisplay)
        {

            Panel panelInnerEvents = new Panel();
            Label labelDay = new Label();
            // 
            // flowLayoutPanel
            // 
            panelInnerEvents.Location = isWeekDisplay ? new Point(5, 0) : new Point(10, 22);
            panelInnerEvents.Margin = new Padding(0);
            panelInnerEvents.Padding = new Padding(0);
            panelInnerEvents.Name = $"panelInnerEvents{i + 1}";
            panelInnerEvents.Size = isWeekDisplay ? new Size(86, 600) : new Size(70, 56);
            panelInnerEvents.TabIndex = 1;
            panelInnerEvents.Click += new EventHandler(panelInnerEvents_Click);
            panelInnerEvents.MouseEnter += new EventHandler(panelInnerEvents_MouseEnter);
            panelInnerEvents.MouseLeave += new EventHandler(panelInnerEvents_MouseLeave);
            // 
            // label
            // 
            labelDay.Font = new Font("Tw Cen MT Condensed", 8.75F, FontStyle.Bold);
            labelDay.ForeColor = i % 7 == 0 ? Color.FromArgb(56, 149, 211) : Color.Gainsboro;
            labelDay.BackColor = Color.FromArgb(0, 56, 149, 211);
            labelDay.Location = isWeekDisplay ? new Point(0, 0) : new Point(5, 5);
            labelDay.Margin = new Padding(5, 5, 0, 0);
            labelDay.Name = $"label{i + 1}";
            labelDay.Size = new Size(18, 15);
            labelDay.TabIndex = 0;
            labelDay.Text = dayCounter.ToString();
            //
            // panel
            //
            Cursor = Cursors.Hand;
            Font = new Font("Tw Cen MT Condensed", 8.75F, System.Drawing.FontStyle.Bold);
            ForeColor = Color.Gainsboro;
            Location = new Point(width, height);
            Margin = isWeekDisplay ? new Padding(2, 0, 2, 0) : new Padding(5);
            Name = $"panel{i + 1}";
            Size = new Size(isWeekDisplay ? 96 : 90, isWeekDisplay ? 600 : 90);
            Text = null;
            BackColor = Color.FromArgb(80, 46, 46, 46);
            panelInnerEvents.Controls.Add(GenerateInfoButton());
            Controls.Add(labelDay);
            Controls.Add(panelInnerEvents);
        }

        private void panelInnerEvents_Click(object sender, EventArgs e)
        {
            caller.CurrentDayButton_Click(this, e);
        }

        private void panelInnerEvents_MouseEnter(object sender, EventArgs e)
        {
            caller.CurrentDayButton_MouseEnter(this, e);
        }

        private void panelInnerEvents_MouseLeave(object sender, EventArgs e)
        {
            caller.CurrentDayButton_MouseLeave(this, e);
        }
    }
}

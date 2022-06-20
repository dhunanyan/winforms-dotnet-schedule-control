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

        public string Date { get; set; }

        public CustomScheduleDay(CustomSchedule.CustomSchedule caller, int i, int width, int height, int dayCounter, string date)
        {
            IntializeDay(i, width, height, dayCounter);
            this.caller = caller;
            Date = date;
        }

        public void IntializeDay(int i, int width, int height, int dayCounter)
        {
            FlowLayoutPanel flowLayoutPanelDay = new FlowLayoutPanel();
            Label labelDay = new Label();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanelDay.Location = new Point(10, 22);
            flowLayoutPanelDay.Margin = new Padding(0);
            flowLayoutPanelDay.Name = $"flowLayoutPanelDay{i + 1}";
            flowLayoutPanelDay.Size = new Size(70, 56);
            flowLayoutPanelDay.TabIndex = 1;
            flowLayoutPanelDay.Click += new EventHandler(flowLayoutPanelDay_Click);
            flowLayoutPanelDay.MouseEnter += new EventHandler(flowLayoutPanelDay_MouseEnter);
            flowLayoutPanelDay.MouseLeave += new EventHandler(flowLayoutPanelDay_MouseLeave);
            // 
            // label
            // 
            labelDay.Font = new Font("Tw Cen MT Condensed", 8.75F, FontStyle.Bold);
            labelDay.ForeColor = i % 7 == 0 ? Color.FromArgb(56, 149, 211) : Color.Gainsboro;
            labelDay.Location = new Point(5, 5);
            labelDay.Margin = new Padding(5, 5, 0, 0);
            labelDay.Name = $"label{i + 1}";
            labelDay.Size = new Size(40, 15);
            labelDay.TabIndex = 0;
            labelDay.Text = dayCounter.ToString();
            //
            // panel
            //
            Cursor = Cursors.Hand;
            Font = new Font("Tw Cen MT Condensed", 8.75F, System.Drawing.FontStyle.Bold);
            ForeColor = Color.Gainsboro;
            Location = new Point(width, height);
            Margin = new Padding(5);
            Name = $"panel{i + 1}";
            Size = new Size(90, 90);
            Text = null;
            BackColor = Color.FromArgb(80, 46, 46, 46);
            Controls.Add(flowLayoutPanelDay);
            Controls.Add(labelDay);
        }

        private void flowLayoutPanelDay_Click(object sender, EventArgs e)
        {
            caller.CurrentDayButton_Click(this, e);
        }

        private void flowLayoutPanelDay_MouseEnter(object sender, EventArgs e)
        {
            caller.CurrentDayButton_MouseEnter(this, e);
        }

        private void flowLayoutPanelDay_MouseLeave(object sender, EventArgs e)
        {
            caller.CurrentDayButton_MouseLeave(this, e);
        }
    }
}

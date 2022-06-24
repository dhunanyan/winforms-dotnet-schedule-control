using CustomCalendar.CustomControls;
using CustomCalendar.CustomControls.CustomSchedule;
using CustomCalendar.CustomControls.CustomScheduleDay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCalendar
{
    public partial class CustomScheduleDayPopup : Form
    {
        public CustomScheduleDay caller;

        public CustomScheduleEvent currentEvent;

        Button addedEvent = new Button();
        public CustomScheduleDayPopup(CustomScheduleDay caller)
        {
            currentEvent = new CustomScheduleEvent(this)
            {
                Date = caller.caller.ConvertDateWithZeros(caller.Date)
            };
            this.caller = caller;
            InitializeComponent();
        }


        public void GenerateDateTextBox(string text)
        {
            textBoxDate = new TextBox();
            textBoxDate.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            textBoxDate.BorderStyle = BorderStyle.FixedSingle;
            textBoxDate.Enabled = false;
            textBoxDate.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold);
            textBoxDate.ForeColor = Color.Gainsboro;
            textBoxDate.Location = new Point(30, 56);
            textBoxDate.Margin = new Padding(0);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(220, 33);
            textBoxDate.TabIndex = 0;
            textBoxDate.Text = text;
            Controls.Add(textBoxDate);
        }

        private static TextBox textBoxDate;

        private void GenerateComboBoxTo()
        {
            comboBoxTo.Items.Clear();
            DateTime currentTime;
            if (comboBoxFrom.SelectedItem != null)
            {
                currentTime = DateTime.Parse((string)comboBoxFrom.SelectedItem).AddMinutes(30);
            }
            else
            {
                currentTime = DateTime.Parse("00:30");
            }

            while (currentTime < DateTime.Parse("23:59"))
            {
                comboBoxTo.Items.Add(currentTime.ToString("HH:mm"));
                currentTime = currentTime.AddMinutes(30);
            }

            comboBoxTo.Items.Add("00:00");
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxFrom = sender as ComboBox;
            currentEvent.TimeFrom = comboBoxFrom.SelectedItem.ToString();
            GenerateComboBoxTo();
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxTo = sender as ComboBox;
            currentEvent.TimeTo = comboBoxTo.SelectedItem.ToString();
        }

        private void comboBoxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxPriority = sender as ComboBox;
            currentEvent.Priority = comboBoxPriority.SelectedItem.ToString();
        }
        private void textBoxEvent_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxTitle = sender as TextBox;
            currentEvent.Title = textBoxTitle.Text;
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            if(currentEvent.TimeFrom != null && currentEvent.TimeTo != null && currentEvent.Title != null && currentEvent.Priority != null)
            {
                if (caller.caller.AllEvents.Keys.Contains(currentEvent.Date))
                {
                    caller.caller.AllEvents[currentEvent.Date].Add(currentEvent);
                }
                else
                {
                    caller.caller.AllEvents.Add(currentEvent.Date, new List<CustomScheduleEvent> { currentEvent });
                }

                addedEvent.Font = new Font("Microsoft JhengHei Light", caller.caller.IsWeekDisplayed ? 8F : 4.5F, FontStyle.Bold);
                addedEvent.ForeColor = Color.FromArgb(64, 64, 64);
                addedEvent.Text = caller.caller.IsWeekDisplayed ? $"{currentEvent.Title}\r\n{currentEvent.TimeFrom}-{currentEvent.TimeTo}" : (currentEvent.Title.Length > 7 ? currentEvent.Title.Substring(0, 7) + "..." : currentEvent.Title);
                addedEvent.Size = caller.caller.IsWeekDisplayed ? new Size(86, caller.caller.GetEventStartOrAnd(currentEvent.TimeTo) - caller.caller.GetEventStartOrAnd(currentEvent.TimeFrom)) : new Size(68, 16);
                addedEvent.Margin = new Padding(1);
                addedEvent.Padding = new Padding(0);
                addedEvent.FlatStyle = FlatStyle.Flat;
                addedEvent.Cursor = Cursors.Hand;
                addedEvent.Tag = caller.currentDayEventsCount;
                addedEvent.Location = caller.caller.IsWeekDisplayed ? new Point(0, caller.caller.GetEventStartOrAnd(currentEvent.TimeFrom)) : new Point(0, 20 * caller.currentDayEventsCount);
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
                    addedEvent.BackColor = Color.FromArgb(190, 177, 170, 235);
                    addedEvent.FlatAppearance.BorderColor = Color.FromArgb(131, 120, 222);
                }

                ((Panel)caller.Controls.Find($"panelInnerEvents{caller.Name.Split('l')[1]}", true)[0]).Controls.Add(addedEvent);


                if (caller.currentDayEventsCount > 2 && !caller.caller.IsWeekDisplayed)
                {
                    foreach(Button ev in ((Panel)caller.Controls.Find($"panelInnerEvents{caller.Name.Split('l')[1]}", true)[0]).Controls)
                    {
                        if (int.Parse(ev.Tag.ToString()) >= 2)
                        {
                            ev.Visible = false;
                        }
                    }

                    caller.infoButton.Visible = true;
                    caller.infoButton.Text = "+" + (caller.currentDayEventsCount - 1).ToString();
                    caller.infoButton.ForeColor = Color.FromArgb(241, 241, 241);
                }

                caller.caller.DisabledPastEvents();
                caller.caller.timer1.Interval = 1;
                caller.caller.counter = 0;
                caller.currentDayEventsCount++;
                ((Panel)caller.Controls.Find($"panelInnerEvents{caller.Name.Split('l')[1]}", true)[0]).Controls.SetChildIndex(addedEvent, caller.caller.AllEvents[currentEvent.Date].Count() - Array.IndexOf(caller.caller.AllEvents[currentEvent.Date].ToArray(), currentEvent));
                Close();
            }
            else
            {
                MessageBox.Show("Please fill the form", "EventAdd Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

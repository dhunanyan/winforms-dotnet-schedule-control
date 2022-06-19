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
    public partial class FormDayPopup : Form
    {
        public CustomScheduleDay caller;

        public CustomScheduleEvent currentEvent = new CustomScheduleEvent();
        public FormDayPopup(CustomScheduleDay caller)
        {
            currentEvent.Date = caller.Date;
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
                caller.caller.AllEvents.Add(currentEvent.Date, new List<CustomScheduleEvent> { currentEvent });

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

                Console.WriteLine(currentEvent.Priority);

                if(currentEvent.Priority == "High")
                {
                    addedEvent.BackColor = Color.FromArgb(222, 23, 56);
                }
                else if(currentEvent.Priority == "Medium")
                {
                    addedEvent.BackColor = Color.FromArgb(247, 222, 58);

                }
                else if(currentEvent.Priority == "Low")
                {
                    addedEvent.BackColor = Color.FromArgb(118, 187, 104);
                }
                else
                {
                    addedEvent.BackColor = Color.FromArgb(72, 97, 163);
                }

                ((FlowLayoutPanel)caller.Controls.Find($"flowLayoutPanelDay{caller.Name.Split('l')[1]}", true)[0]).Controls.Add(addedEvent);
                Close();
            }
            else
            {
                MessageBox.Show("Please fill the form", "EventAdd Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

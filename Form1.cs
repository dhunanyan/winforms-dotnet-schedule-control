using CustomCalendar.CustomControls;
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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            GetScheduleEvents();
        }
        
        private void GetScheduleEvents()
        {
            foreach(Control c in ((FlowLayoutPanel)((FlowLayoutPanel)customSchedule1.Controls.Find("flowLayoutPanelMain", true)[0]).Controls.Find("flowLayoutPanelDays", true)[0]).Controls)
            {
                if (c is CustomScheduleDay)
                {
                    CustomScheduleDay currentDay = c as CustomScheduleDay;
                    //if(!(currentDay.AddedEvents.Count == 0))
                    //{
                    //    AllEvents.Add(currentDay.Date, currentDay.AddedEvents);
                    //}
                }
            }
        }
    }
}

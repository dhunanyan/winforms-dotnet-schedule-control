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
            this.customSchedule1.AllEvents = ((System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<CustomCalendar.CustomControls.CustomScheduleEvent>>)(new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<CustomCalendar.CustomControls.CustomScheduleEvent>>()));
        }
    }
}

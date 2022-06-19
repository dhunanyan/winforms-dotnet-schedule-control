using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCalendar.CustomControls
{
    public class CustomScheduleEvent
    {
        public CustomScheduleEvent(string timeFrom, string timeTo, string date, string title, string priority)
        {
            TimeFrom = timeFrom;
            TimeTo = timeTo;
            Date = date;
            Title = title;
            Priority = priority;
        }

        public CustomScheduleEvent()
        {

        }

        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public string Date  { get; set; }
        public string Title  { get; set; }
        public string Priority  { get; set; }
    }
}

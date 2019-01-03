using System;
using System.ComponentModel;
using Syncfusion.SfCalendar.XForms;

namespace LocalizingCustomtextsfromPCL
{
    public class ViewModel 
    {
        public CalendarEventCollection CalendarInlineEvents { get; set; } = new CalendarEventCollection();

        public ViewModel()
        {
            //Add collection of events as source of SfCalendar
            CalendarInlineEvents.Add(new CalendarInlineEvent()
            {
                Subject = "Goto Meeting",
                StartTime = DateTime.Today.AddHours(10),
                EndTime = DateTime.Today.AddHours(12),
                IsAllDay = true,
            });
        }

    }
}

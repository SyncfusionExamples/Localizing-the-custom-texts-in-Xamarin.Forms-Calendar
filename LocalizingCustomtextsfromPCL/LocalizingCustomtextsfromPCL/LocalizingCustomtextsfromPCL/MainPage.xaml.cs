using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalizingCustomtextsfromPCL
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            // set Calendar Resource manager
            CalendarResourceManager.Manager = new System.Resources.ResourceManager("LocalizingCustomtextsfromPCL.Resources.Syncfusion.SfCalendar.XForms", GetType().GetTypeInfo().Assembly);
            //Set Locale for Calendar
            CultureInfo.CurrentUICulture = new CultureInfo("pt");
            calendar.Locale = new System.Globalization.CultureInfo("pt-PT");

            // Creating Events in SfCalendar
            CalendarEventCollection calendarInlineEvents = new CalendarEventCollection();

            calendarInlineEvents.Add(new CalendarInlineEvent()
            {
                Subject = "Goto Meeting",
                StartTime = DateTime.Today.AddHours(10),
                EndTime = DateTime.Today.AddHours(12),
                IsAllDay = true,
            });

            //Add collection of events as source of SfCalendar
            calendar.DataSource = calendarInlineEvents;
        }
	}
}

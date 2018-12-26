using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalendarLocalization
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            CalendarResourceManager.Manager = new System.Resources.ResourceManager("CalendarLocalization.Resources.Syncfusion.SfCalendar.XForms", GetType().GetTypeInfo().Assembly);
            CultureInfo.CurrentUICulture = new CultureInfo("pt");
            calendar.Locale = new System.Globalization.CultureInfo("pt-PT");

            calendar.MonthViewSettings = new MonthViewSettings()
            {
                SelectedDayTextColor= Color.White,
                TodayTextColor = Color.FromHex("#007CEE")

            };

            // Creating Events in SfCalendar
            CalendarEventCollection calendarInlineEvents = new CalendarEventCollection();

            calendarInlineEvents.Add(new CalendarInlineEvent()
            {
                Subject = "Goto Meeting",
                StartTime = DateTime.Today.AddHours(10),
                EndTime = DateTime.Today.AddHours(12),
                IsAllDay = true,
            });

            calendar.DataSource = calendarInlineEvents;
        }
	}
}

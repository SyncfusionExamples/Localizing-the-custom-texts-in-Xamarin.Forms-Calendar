using System;
using System.Globalization;
using System.Reflection;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace LocalizingCustomtextsfromPCL
{
    public class CalendarBehavior: Behavior<SfCalendar>
    {
        SfCalendar calendar;
        public CalendarBehavior()
        {
        }

        protected override void OnAttachedTo(SfCalendar bindable)
        {
            base.OnAttachedTo(bindable);

            calendar = bindable;

            // set Calendar Resource manager
            CalendarResourceManager.Manager = new System.Resources.ResourceManager("LocalizingCustomtextsfromPCL.Resources.Syncfusion.SfCalendar.XForms", GetType().GetTypeInfo().Assembly);
            //Set Locale for Calendar
            CultureInfo.CurrentUICulture = new CultureInfo("pt");
            calendar.Locale = new System.Globalization.CultureInfo("pt-PT");
        }

        protected override void OnDetachingFrom(SfCalendar bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}

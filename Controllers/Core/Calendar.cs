using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Calendar : BaseController
	{

		public Calendar() : base()
		{
		}

		public Calendar(string token, string url) : base(token, url)
		{
		}

		public CalendarEventsModel CreateCalendarEvents(CalendarEventsInputModel calendarEventsInputModel)
		{
			return Post<CalendarEventsModel,CalendarEventsInputModel>("core_calendar_create_calendar_events", calendarEventsInputModel);
		}

		public void DeleteCalendarEvents(DeleteCalendarEventsInputModel deleteCalendarEventsInputModel)
		{
			Post<DeleteCalendarEventsInputModel>("core_calendar_delete_calendar_events", deleteCalendarEventsInputModel);
		}

		public ActionEventsByCourseModel GetActionEventsByCourse(ActionEventsByCourseInputModel actionEventsByCourseInputModel)
		{
			return Post<ActionEventsByCourseModel,ActionEventsByCourseInputModel>("core_calendar_get_action_events_by_course", actionEventsByCourseInputModel);
		}

		public ActionEventsByCoursesModel GetActionEventsByCourses(ActionEventsByCoursesInputModel actionEventsByCoursesInputModel)
		{
			return Post<ActionEventsByCoursesModel,ActionEventsByCoursesInputModel>("core_calendar_get_action_events_by_courses", actionEventsByCoursesInputModel);
		}

		public ActionEventsByCourseModel GetActionEventsByTimesort(ActionEventsByTimesortInputModel actionEventsByTimesortInputModel)
		{
			return Post<ActionEventsByCourseModel,ActionEventsByTimesortInputModel>("core_calendar_get_action_events_by_timesort", actionEventsByTimesortInputModel);
		}

		public CalendarEventsModel GetCalendarEvents(GetCalendarEventsInputModel getCalendarEventsInputModel)
		{
			return Post<CalendarEventsModel,GetCalendarEventsInputModel>("core_calendar_get_calendar_events", getCalendarEventsInputModel);
		}

		//Function Placeholder

	}
}
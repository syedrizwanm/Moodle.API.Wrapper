using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Calendar : BaseController
	{

		public Calendar() : base()
		{
		}

		public Calendar(string token, string url) : base(token, url)
		{
		}

		public Task<CalendarEventsModel> CreateCalendarEvents(CalendarEventsInputModel calendarEventsInputModel)
		{
			return Post<CalendarEventsModel,CalendarEventsInputModel>("core_calendar_create_calendar_events", calendarEventsInputModel);
		}

		public Task DeleteCalendarEvents(DeleteCalendarEventsInputModel deleteCalendarEventsInputModel)
		{
			return Post<DeleteCalendarEventsInputModel>("core_calendar_delete_calendar_events", deleteCalendarEventsInputModel);
		}

		public Task<ActionEventsByCourseModel> GetActionEventsByCourse(ActionEventsByCourseInputModel actionEventsByCourseInputModel)
		{
			return Post<ActionEventsByCourseModel,ActionEventsByCourseInputModel>("core_calendar_get_action_events_by_course", actionEventsByCourseInputModel);
		}

		public Task<ActionEventsByCoursesModel> GetActionEventsByCourses(ActionEventsByCoursesInputModel actionEventsByCoursesInputModel)
		{
			return Post<ActionEventsByCoursesModel,ActionEventsByCoursesInputModel>("core_calendar_get_action_events_by_courses", actionEventsByCoursesInputModel);
		}

		public Task<ActionEventsByCourseModel> GetActionEventsByTimesort(ActionEventsByTimesortInputModel actionEventsByTimesortInputModel)
		{
			return Post<ActionEventsByCourseModel,ActionEventsByTimesortInputModel>("core_calendar_get_action_events_by_timesort", actionEventsByTimesortInputModel);
		}

		public Task<CalendarEventsModel> GetCalendarEvents(GetCalendarEventsInputModel getCalendarEventsInputModel)
		{
			return Post<CalendarEventsModel,GetCalendarEventsInputModel>("core_calendar_get_calendar_events", getCalendarEventsInputModel);
		}

		//Function Placeholder

	}
}
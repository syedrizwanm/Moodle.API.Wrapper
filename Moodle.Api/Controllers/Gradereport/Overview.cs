using System.Threading.Tasks;
using Moodle.Api.Models.Gradereport;

namespace Moodle.Api.Controllers.Gradereport
{
	public sealed class Overview : BaseController
	{

		public Overview() : base()
		{
		}

		public Overview(string token, string url) : base(token, url)
		{
		}

		public Task<CourseGradesModel> GetCourseGrades(UserPlansInputModel userPlansInputModel)
		{
			return Post<CourseGradesModel,UserPlansInputModel>("gradereport_overview_get_course_grades", userPlansInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewGradeReport(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ActivitiesCompletionStatusInputModel>("gradereport_overview_view_grade_report", activitiesCompletionStatusInputModel);
		}

		//Function Placeholder

	}
}
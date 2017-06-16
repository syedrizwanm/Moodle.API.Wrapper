using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Gradereport;

namespace Moodle.API.Wrapper.Controllers.Gradereport
{
	public sealed class Overview : BaseController
	{

		public Overview() : base()
		{
		}

		public Overview(string token, string url) : base(token, url)
		{
		}

		public CourseGradesModel GetCourseGrades(UserPlansInputModel userPlansInputModel)
		{
			return Post<CourseGradesModel,UserPlansInputModel>("gradereport_overview_get_course_grades", userPlansInputModel);
		}

		public MarkCourseSelfCompletedModel ViewGradeReport(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ActivitiesCompletionStatusInputModel>("gradereport_overview_view_grade_report", activitiesCompletionStatusInputModel);
		}

		//Function Placeholder

	}
}
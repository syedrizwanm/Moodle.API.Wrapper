using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Gradereport;

namespace Moodle.API.Wrapper.Controllers.Gradereport
{
	public sealed class User : BaseController
	{

		public User() : base()
		{
		}

		public User(string token, string url) : base(token, url)
		{
		}

		public GradeItemsModel GetGradeItems(GradesTableInputModel gradesTableInputModel)
		{
			return Post<GradeItemsModel,GradesTableInputModel>("gradereport_user_get_grade_items", gradesTableInputModel);
		}

		public GradesTableModel GetGradesTable(GradesTableInputModel gradesTableInputModel)
		{
			return Post<GradesTableModel,GradesTableInputModel>("gradereport_user_get_grades_table", gradesTableInputModel);
		}

		public MarkCourseSelfCompletedModel ViewGradeReport(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ActivitiesCompletionStatusInputModel>("gradereport_user_view_grade_report", activitiesCompletionStatusInputModel);
		}

		//Function Placeholder

	}
}
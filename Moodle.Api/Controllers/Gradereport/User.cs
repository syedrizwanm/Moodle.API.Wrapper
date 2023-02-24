using System.Threading.Tasks;
using Moodle.Api.Models.Gradereport;

namespace Moodle.Api.Controllers.Gradereport
{
	public sealed class User : BaseController
	{

		public User() : base()
		{
		}

		public User(string token, string url) : base(token, url)
		{
		}

		public Task<GradeItemsModel> GetGradeItems(GradesTableInputModel gradesTableInputModel)
		{
			return Post<GradeItemsModel,GradesTableInputModel>("gradereport_user_get_grade_items", gradesTableInputModel);
		}

		public Task<GradesTableModel> GetGradesTable(GradesTableInputModel gradesTableInputModel)
		{
			return Post<GradesTableModel,GradesTableInputModel>("gradereport_user_get_grades_table", gradesTableInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewGradeReport(ActivitiesCompletionStatusInputModel activitiesCompletionStatusInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ActivitiesCompletionStatusInputModel>("gradereport_user_view_grade_report", activitiesCompletionStatusInputModel);
		}

		//Function Placeholder

	}
}
using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Grades : BaseController
	{

		public Grades() : base()
		{
		}

		public Grades(string token, string url) : base(token, url)
		{
		}

		public Task<GradesModel> GetGrades(GradesInputModel gradesInputModel)
		{
			return Post<GradesModel,GradesInputModel>("core_grades_get_grades", gradesInputModel);
		}

		public Task<int> UpdateGrades(UpdateGradesInputModel updateGradesInputModel)
		{
			return Post<int,UpdateGradesInputModel>("core_grades_update_grades", updateGradesInputModel);
		}

		//Function Placeholder

	}
}
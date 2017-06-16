using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Grades : BaseController
	{

		public Grades() : base()
		{
		}

		public Grades(string token, string url) : base(token, url)
		{
		}

		public GradesModel GetGrades(GradesInputModel gradesInputModel)
		{
			return Post<GradesModel,GradesInputModel>("core_grades_get_grades", gradesInputModel);
		}

		public int UpdateGrades(UpdateGradesInputModel updateGradesInputModel)
		{
			return Post<int,UpdateGradesInputModel>("core_grades_update_grades", updateGradesInputModel);
		}

		//Function Placeholder

	}
}
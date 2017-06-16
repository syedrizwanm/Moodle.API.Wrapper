using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Label : BaseController
	{

		public Label() : base()
		{
		}

		public Label(string token, string url) : base(token, url)
		{
		}

		public LabelsByCoursesModel GetLabelsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<LabelsByCoursesModel,DeleteCoursesInputModel>("mod_label_get_labels_by_courses", deleteCoursesInputModel);
		}

		//Function Placeholder

	}
}
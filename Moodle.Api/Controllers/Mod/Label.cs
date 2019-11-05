using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Label : BaseController
	{

		public Label() : base()
		{
		}

		public Label(string token, string url) : base(token, url)
		{
		}

		public Task<LabelsByCoursesModel> GetLabelsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<LabelsByCoursesModel, DeleteCoursesInputModel>("mod_label_get_labels_by_courses", deleteCoursesInputModel);
		}

		//Function Placeholder

	}
}
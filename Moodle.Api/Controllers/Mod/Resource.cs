using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Resource : BaseController
	{

		public Resource() : base()
		{
		}

		public Resource(string token, string url) : base(token, url)
		{
		}

		public Task<ResourcesByCoursesModel> GetResourcesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ResourcesByCoursesModel,DeleteCoursesInputModel>("mod_resource_get_resources_by_courses", deleteCoursesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewResource(ViewResourceInputModel viewResourceInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewResourceInputModel>("mod_resource_view_resource", viewResourceInputModel);
		}

		//Function Placeholder

	}
}
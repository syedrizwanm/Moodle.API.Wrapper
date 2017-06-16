using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Resource : BaseController
	{

		public Resource() : base()
		{
		}

		public Resource(string token, string url) : base(token, url)
		{
		}

		public ResourcesByCoursesModel GetResourcesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ResourcesByCoursesModel,DeleteCoursesInputModel>("mod_resource_get_resources_by_courses", deleteCoursesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewResource(ViewResourceInputModel viewResourceInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewResourceInputModel>("mod_resource_view_resource", viewResourceInputModel);
		}

		//Function Placeholder

	}
}
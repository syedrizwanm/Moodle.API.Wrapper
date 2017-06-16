using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Url : BaseController
	{

		public Url() : base()
		{
		}

		public Url(string token, string url) : base(token, url)
		{
		}

		public UrlsByCoursesModel GetUrlsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<UrlsByCoursesModel,DeleteCoursesInputModel>("mod_url_get_urls_by_courses", deleteCoursesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewUrl(ViewUrlInputModel viewUrlInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewUrlInputModel>("mod_url_view_url", viewUrlInputModel);
		}

		//Function Placeholder

	}
}
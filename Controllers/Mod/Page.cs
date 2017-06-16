using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Page : BaseController
	{

		public Page() : base()
		{
		}

		public Page(string token, string url) : base(token, url)
		{
		}

		public PagesByCoursesModel GetPagesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<PagesByCoursesModel,DeleteCoursesInputModel>("mod_page_get_pages_by_courses", deleteCoursesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewPage(ViewPageInputModel viewPageInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewPageInputModel>("mod_page_view_page", viewPageInputModel);
		}

		//Function Placeholder

	}
}
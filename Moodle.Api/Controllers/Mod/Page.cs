using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Page : BaseController
	{

		public Page() : base()
		{
		}

		public Page(string token, string url) : base(token, url)
		{
		}

		public Task<PagesByCoursesModel> GetPagesByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<PagesByCoursesModel,DeleteCoursesInputModel>("mod_page_get_pages_by_courses", deleteCoursesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewPage(ViewPageInputModel viewPageInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewPageInputModel>("mod_page_view_page", viewPageInputModel);
		}

		//Function Placeholder

	}
}
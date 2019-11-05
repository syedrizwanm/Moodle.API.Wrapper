using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Url : BaseController
	{

		public Url() : base()
		{
		}

		public Url(string token, string url) : base(token, url)
		{
		}

		public Task<UrlsByCoursesModel> GetUrlsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<UrlsByCoursesModel,DeleteCoursesInputModel>("mod_url_get_urls_by_courses", deleteCoursesInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewUrl(ViewUrlInputModel viewUrlInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewUrlInputModel>("mod_url_view_url", viewUrlInputModel);
		}

		//Function Placeholder

	}
}
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Imscp : BaseController
	{

		public Imscp() : base()
		{
		}

		public Imscp(string token, string url) : base(token, url)
		{
		}

		public ImscpsByCoursesModel GetImscpsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ImscpsByCoursesModel,DeleteCoursesInputModel>("mod_imscp_get_imscps_by_courses", deleteCoursesInputModel);
		}

		public MarkCourseSelfCompletedModel ViewImscp(ViewImscpInputModel viewImscpInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewImscpInputModel>("mod_imscp_view_imscp", viewImscpInputModel);
		}

		//Function Placeholder

	}
}
using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Webservice : BaseController
	{

		public Webservice() : base()
		{
		}

		public Webservice(string token, string url) : base(token, url)
		{
		}

		public Task<SiteInfoModel> GetSiteInfo(SiteInfoInputModel siteInfoInputModel)
		{
			return Post<SiteInfoModel,SiteInfoInputModel>("core_webservice_get_site_info", siteInfoInputModel);
		}

		//Function Placeholder

	}
}
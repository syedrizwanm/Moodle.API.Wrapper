using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Webservice : BaseController
	{

		public Webservice() : base()
		{
		}

		public Webservice(string token, string url) : base(token, url)
		{
		}

		public SiteInfoModel GetSiteInfo(SiteInfoInputModel siteInfoInputModel)
		{
			return Post<SiteInfoModel,SiteInfoInputModel>("core_webservice_get_site_info", siteInfoInputModel);
		}

		//Function Placeholder

	}
}
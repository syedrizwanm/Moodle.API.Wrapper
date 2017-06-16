using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Tool;

namespace Moodle.API.Wrapper.Controllers.Tool
{
	public sealed class Mobile : BaseController
	{

		public Mobile() : base()
		{
		}

		public Mobile(string token, string url) : base(token, url)
		{
		}

		public AutologinKeyModel GetAutologinKey(AutologinKeyInputModel autologinKeyInputModel)
		{
			return Post<AutologinKeyModel,AutologinKeyInputModel>("tool_mobile_get_autologin_key", autologinKeyInputModel);
		}

		public ConfigModel GetConfig(ConfigInputModel configInputModel)
		{
			return Post<ConfigModel,ConfigInputModel>("tool_mobile_get_config", configInputModel);
		}

		public PluginsSupportingMobileModel GetPluginsSupportingMobile( )
		{
			return Post<PluginsSupportingMobileModel>("tool_mobile_get_plugins_supporting_mobile");
		}

		public PublicConfigModel GetPublicConfig( )
		{
			return Post<PublicConfigModel>("tool_mobile_get_public_config");
		}

		//Function Placeholder

	}
}
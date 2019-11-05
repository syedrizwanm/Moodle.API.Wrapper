using System.Threading.Tasks;
using Moodle.Api.Models.Tool;

namespace Moodle.Api.Controllers.Tool
{
	public sealed class Mobile : BaseController
	{

		public Mobile() : base()
		{
		}

		public Mobile(string token, string url) : base(token, url)
		{
		}

		public Task<AutologinKeyModel> GetAutologinKey(AutologinKeyInputModel autologinKeyInputModel)
		{
			return Post<AutologinKeyModel,AutologinKeyInputModel>("tool_mobile_get_autologin_key", autologinKeyInputModel);
		}

		public Task<ConfigModel> GetConfig(ConfigInputModel configInputModel)
		{
			return Post<ConfigModel,ConfigInputModel>("tool_mobile_get_config", configInputModel);
		}

		public Task<PluginsSupportingMobileModel> GetPluginsSupportingMobile( )
		{
			return Post<PluginsSupportingMobileModel>("tool_mobile_get_plugins_supporting_mobile");
		}

		public Task<PublicConfigModel> GetPublicConfig( )
		{
			return Post<PublicConfigModel>("tool_mobile_get_public_config");
		}

		//Function Placeholder

	}
}
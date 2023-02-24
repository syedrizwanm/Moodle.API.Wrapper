using System.Threading.Tasks;
using Moodle.Api.Models.Mod;

namespace Moodle.Api.Controllers.Mod
{
	public sealed class Lti : BaseController
	{

		public Lti() : base()
		{
		}

		public Lti(string token, string url) : base(token, url)
		{
		}

		public Task<ToolProxyModel> CreateToolProxy(ToolProxyInputModel toolProxyInputModel)
		{
			return Post<ToolProxyModel,ToolProxyInputModel>("mod_lti_create_tool_proxy", toolProxyInputModel);
		}

		public Task<ToolTypeModel> CreateToolType(ToolTypeInputModel toolTypeInputModel)
		{
			return Post<ToolTypeModel,ToolTypeInputModel>("mod_lti_create_tool_type", toolTypeInputModel);
		}

		public Task<ToolProxyModel> DeleteToolProxy(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<ToolProxyModel,ApprovePlanInputModel>("mod_lti_delete_tool_proxy", approvePlanInputModel);
		}

		public Task<DeleteToolTypeModel> DeleteToolType(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<DeleteToolTypeModel,ApprovePlanInputModel>("mod_lti_delete_tool_type", approvePlanInputModel);
		}

		public Task<LtisByCoursesModel> GetLtisByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<LtisByCoursesModel,DeleteCoursesInputModel>("mod_lti_get_ltis_by_courses", deleteCoursesInputModel);
		}

		public Task<ToolLaunchDataModel> GetToolLaunchData(ToolLaunchDataInputModel toolLaunchDataInputModel)
		{
			return Post<ToolLaunchDataModel,ToolLaunchDataInputModel>("mod_lti_get_tool_launch_data", toolLaunchDataInputModel);
		}

		public Task<ToolProxiesModel> GetToolProxies(ToolProxiesInputModel toolProxiesInputModel)
		{
			return Post<ToolProxiesModel,ToolProxiesInputModel>("mod_lti_get_tool_proxies", toolProxiesInputModel);
		}

		public Task<ToolProxyRegistrationRequestModel> GetToolProxyRegistrationRequest(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<ToolProxyRegistrationRequestModel,ApprovePlanInputModel>("mod_lti_get_tool_proxy_registration_request", approvePlanInputModel);
		}

		public Task<ToolProxiesModel> GetToolTypes(ToolTypesInputModel toolTypesInputModel)
		{
			return Post<ToolProxiesModel,ToolTypesInputModel>("mod_lti_get_tool_types", toolTypesInputModel);
		}

		public Task<IsCartridgeModel> IsCartridge(IsCartridgeInputModel isCartridgeInputModel)
		{
			return Post<IsCartridgeModel,IsCartridgeInputModel>("mod_lti_is_cartridge", isCartridgeInputModel);
		}

		public Task<ToolTypeModel> UpdateToolType(UpdateToolTypeInputModel updateToolTypeInputModel)
		{
			return Post<ToolTypeModel,UpdateToolTypeInputModel>("mod_lti_update_tool_type", updateToolTypeInputModel);
		}

		public Task<MarkCourseSelfCompletedModel> ViewLti(ViewLtiInputModel viewLtiInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewLtiInputModel>("mod_lti_view_lti", viewLtiInputModel);
		}

		//Function Placeholder

	}
}
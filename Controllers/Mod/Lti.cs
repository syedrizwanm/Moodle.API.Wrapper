using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Lti : BaseController
	{

		public Lti() : base()
		{
		}

		public Lti(string token, string url) : base(token, url)
		{
		}

		public ToolProxyModel CreateToolProxy(ToolProxyInputModel toolProxyInputModel)
		{
			return Post<ToolProxyModel,ToolProxyInputModel>("mod_lti_create_tool_proxy", toolProxyInputModel);
		}

		public ToolTypeModel CreateToolType(ToolTypeInputModel toolTypeInputModel)
		{
			return Post<ToolTypeModel,ToolTypeInputModel>("mod_lti_create_tool_type", toolTypeInputModel);
		}

		public ToolProxyModel DeleteToolProxy(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<ToolProxyModel,ApprovePlanInputModel>("mod_lti_delete_tool_proxy", approvePlanInputModel);
		}

		public DeleteToolTypeModel DeleteToolType(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<DeleteToolTypeModel,ApprovePlanInputModel>("mod_lti_delete_tool_type", approvePlanInputModel);
		}

		public LtisByCoursesModel GetLtisByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<LtisByCoursesModel,DeleteCoursesInputModel>("mod_lti_get_ltis_by_courses", deleteCoursesInputModel);
		}

		public ToolLaunchDataModel GetToolLaunchData(ToolLaunchDataInputModel toolLaunchDataInputModel)
		{
			return Post<ToolLaunchDataModel,ToolLaunchDataInputModel>("mod_lti_get_tool_launch_data", toolLaunchDataInputModel);
		}

		public ToolProxiesModel GetToolProxies(ToolProxiesInputModel toolProxiesInputModel)
		{
			return Post<ToolProxiesModel,ToolProxiesInputModel>("mod_lti_get_tool_proxies", toolProxiesInputModel);
		}

		public ToolProxyRegistrationRequestModel GetToolProxyRegistrationRequest(ApprovePlanInputModel approvePlanInputModel)
		{
			return Post<ToolProxyRegistrationRequestModel,ApprovePlanInputModel>("mod_lti_get_tool_proxy_registration_request", approvePlanInputModel);
		}

		public ToolProxiesModel GetToolTypes(ToolTypesInputModel toolTypesInputModel)
		{
			return Post<ToolProxiesModel,ToolTypesInputModel>("mod_lti_get_tool_types", toolTypesInputModel);
		}

		public IsCartridgeModel IsCartridge(IsCartridgeInputModel isCartridgeInputModel)
		{
			return Post<IsCartridgeModel,IsCartridgeInputModel>("mod_lti_is_cartridge", isCartridgeInputModel);
		}

		public ToolTypeModel UpdateToolType(UpdateToolTypeInputModel updateToolTypeInputModel)
		{
			return Post<ToolTypeModel,UpdateToolTypeInputModel>("mod_lti_update_tool_type", updateToolTypeInputModel);
		}

		public MarkCourseSelfCompletedModel ViewLti(ViewLtiInputModel viewLtiInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewLtiInputModel>("mod_lti_view_lti", viewLtiInputModel);
		}

		//Function Placeholder

	}
}
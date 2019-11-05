using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Role : BaseController
	{

		public Role() : base()
		{
		}

		public Role(string token, string url) : base(token, url)
		{
		}

		public void AssignRoles(AssignRolesInputModel assignRolesInputModel)
		{
			Post<AssignRolesInputModel>("core_role_assign_roles", assignRolesInputModel);
		}

		public void UnassignRoles(UnassignRolesInputModel unassignRolesInputModel)
		{
			Post<UnassignRolesInputModel>("core_role_unassign_roles", unassignRolesInputModel);
		}

		//Function Placeholder

	}
}
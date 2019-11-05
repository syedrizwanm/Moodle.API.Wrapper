using System.Threading.Tasks;
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

		public Task AssignRoles(AssignRolesInputModel assignRolesInputModel)
		{
			return Post<AssignRolesInputModel>("core_role_assign_roles", assignRolesInputModel);
		}

		public Task UnassignRoles(UnassignRolesInputModel unassignRolesInputModel)
		{
			return Post<UnassignRolesInputModel>("core_role_unassign_roles", unassignRolesInputModel);
		}

		//Function Placeholder

	}
}
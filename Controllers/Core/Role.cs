using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
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
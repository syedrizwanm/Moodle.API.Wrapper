using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Auth : BaseController
	{

		public Auth() : base()
		{
		}

		public Auth(string token, string url) : base(token, url)
		{
		}

		public SignupUserModel ConfirmUser(ConfirmUserInputModel confirmUserInputModel)
		{
			return Post<SignupUserModel,ConfirmUserInputModel>("core_auth_confirm_user", confirmUserInputModel);
		}

		//Function Placeholder

	}
}
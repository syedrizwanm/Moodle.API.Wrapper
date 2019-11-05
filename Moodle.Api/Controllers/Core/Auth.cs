using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Auth : BaseController
	{

		public Auth() : base()
		{
		}

		public Auth(string token, string url) : base(token, url)
		{
		}

		public Task<SignupUserModel> ConfirmUser(ConfirmUserInputModel confirmUserInputModel)
		{
			return Post<SignupUserModel,ConfirmUserInputModel>("core_auth_confirm_user", confirmUserInputModel);
		}

		//Function Placeholder

	}
}
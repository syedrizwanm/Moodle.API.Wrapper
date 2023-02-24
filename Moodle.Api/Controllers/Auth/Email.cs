using System.Threading.Tasks;
using Moodle.Api.Models.Auth;

namespace Moodle.Api.Controllers.Auth
{
	public sealed class Email : BaseController
	{

		public Email() : base()
		{
		}

		public Email(string token, string url) : base(token, url)
		{
		}

		public Task<SignupSettingsModel> GetSignupSettings( )
		{
			return Post<SignupSettingsModel>("auth_email_get_signup_settings");
		}

		public Task<SignupUserModel> SignupUser(SignupUserInputModel signupUserInputModel)
		{
			return Post<SignupUserModel,SignupUserInputModel>("auth_email_signup_user", signupUserInputModel);
		}

		//Function Placeholder

	}
}
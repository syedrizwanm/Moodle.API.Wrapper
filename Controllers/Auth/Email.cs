using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Auth;

namespace Moodle.API.Wrapper.Controllers.Auth
{
	public sealed class Email : BaseController
	{

		public Email() : base()
		{
		}

		public Email(string token, string url) : base(token, url)
		{
		}

		public SignupSettingsModel GetSignupSettings( )
		{
			return Post<SignupSettingsModel>("auth_email_get_signup_settings");
		}

		public SignupUserModel SignupUser(SignupUserInputModel signupUserInputModel)
		{
			return Post<SignupUserModel,SignupUserInputModel>("auth_email_signup_user", signupUserInputModel);
		}

		//Function Placeholder

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Badges : BaseController
	{

		public Badges() : base()
		{
		}

		public Badges(string token, string url) : base(token, url)
		{
		}

		public UserBadgesModel GetUserBadges(UserBadgesInputModel userBadgesInputModel)
		{
			return Post<UserBadgesModel,UserBadgesInputModel>("core_badges_get_user_badges", userBadgesInputModel);
		}

		//Function Placeholder

	}
}
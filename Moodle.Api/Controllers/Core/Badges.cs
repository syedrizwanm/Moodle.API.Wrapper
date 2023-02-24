using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Badges : BaseController
	{

		public Badges() : base()
		{
		}

		public Badges(string token, string url) : base(token, url)
		{
		}

		public Task<UserBadgesModel> GetUserBadges(UserBadgesInputModel userBadgesInputModel)
		{
			return Post<UserBadgesModel,UserBadgesInputModel>("core_badges_get_user_badges", userBadgesInputModel);
		}

		//Function Placeholder

	}
}
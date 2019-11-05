using System.Threading.Tasks;
using Moodle.Api.Models.Core;

namespace Moodle.Api.Controllers.Core
{
	public sealed class Fetch : BaseController
	{

		public Fetch() : base()
		{
		}

		public Fetch(string token, string url) : base(token, url)
		{
		}

		public Task<NotificationsModel> Notifications(NotificationsInputModel notificationsInputModel)
		{
			return Post<NotificationsModel,NotificationsInputModel>("core_fetch_notifications", notificationsInputModel);
		}

		//Function Placeholder

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Core;

namespace Moodle.API.Wrapper.Controllers.Core
{
	public sealed class Fetch : BaseController
	{

		public Fetch() : base()
		{
		}

		public Fetch(string token, string url) : base(token, url)
		{
		}

		public NotificationsModel Notifications(NotificationsInputModel notificationsInputModel)
		{
			return Post<NotificationsModel,NotificationsInputModel>("core_fetch_notifications", notificationsInputModel);
		}

		//Function Placeholder

	}
}
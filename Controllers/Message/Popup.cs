using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Message;

namespace Moodle.API.Wrapper.Controllers.Message
{
	public sealed class Popup : BaseController
	{

		public Popup() : base()
		{
		}

		public Popup(string token, string url) : base(token, url)
		{
		}

		public PopupNotificationsModel GetPopupNotifications(PopupNotificationsInputModel popupNotificationsInputModel)
		{
			return Post<PopupNotificationsModel,PopupNotificationsInputModel>("message_popup_get_popup_notifications", popupNotificationsInputModel);
		}

		public int GetUnreadPopupNotificationCount(UnreadConversationsCountInputModel unreadConversationsCountInputModel)
		{
			return Post<int,UnreadConversationsCountInputModel>("message_popup_get_unread_popup_notification_count", unreadConversationsCountInputModel);
		}

		//Function Placeholder

	}
}
using System.Threading.Tasks;
using Moodle.Api.Models.Message;

namespace Moodle.Api.Controllers.Message
{
	public sealed class Popup : BaseController
	{

		public Popup() : base()
		{
		}

		public Popup(string token, string url) : base(token, url)
		{
		}

		public Task<PopupNotificationsModel> GetPopupNotifications(PopupNotificationsInputModel popupNotificationsInputModel)
		{
			return Post<PopupNotificationsModel,PopupNotificationsInputModel>("message_popup_get_popup_notifications", popupNotificationsInputModel);
		}

		public Task<int> GetUnreadPopupNotificationCount(UnreadConversationsCountInputModel unreadConversationsCountInputModel)
		{
			return Post<int,UnreadConversationsCountInputModel>("message_popup_get_unread_popup_notification_count", unreadConversationsCountInputModel);
		}

		//Function Placeholder

	}
}
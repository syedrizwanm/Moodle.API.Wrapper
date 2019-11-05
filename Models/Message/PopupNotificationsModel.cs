using System.Collections.Generic;

namespace Moodle.Api.Models.Message
{
	public sealed class PopupNotificationsModel : IModel 
	{
		public List<Notification> notifications {get;set;}
		public int unreadcount {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var notificationsIndex = 0; notificationsIndex<notifications.Count;notificationsIndex++) 
			{
				var notificationsItem = notifications[notificationsIndex];
				var notificationsItems = notificationsItem.ToKeyValuePairs("notifications[" + notificationsIndex + "]");
				keyValuePairs.AddRange(notificationsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("unreadcount",prefix),unreadcount.ToString()));
			return keyValuePairs;
		}

	}
}
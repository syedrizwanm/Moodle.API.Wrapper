using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Component : IModel 
	{

		public string displayname {get;set;}
		public List<Notification> notifications {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayname",prefix),displayname));

			for(var notificationsIndex = 0; notificationsIndex<notifications.Count;notificationsIndex++) 
			{
				var notificationsItem = notifications[notificationsIndex];
				var notificationsItems = notificationsItem.ToKeyValuePairs("notifications[" + notificationsIndex + "]");
				keyValuePairs.AddRange(notificationsItems);
			}

			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ContactsModel : IModel 
	{
		public List<Offline> offline {get;set;}
		public List<Online> online {get;set;}
		public List<Stranger> strangers {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var offlineIndex = 0; offlineIndex<offline.Count;offlineIndex++) 
			{
				var offlineItem = offline[offlineIndex];
				var offlineItems = offlineItem.ToKeyValuePairs("offline[" + offlineIndex + "]");
				keyValuePairs.AddRange(offlineItems);
			}


			for(var onlineIndex = 0; onlineIndex<online.Count;onlineIndex++) 
			{
				var onlineItem = online[onlineIndex];
				var onlineItems = onlineItem.ToKeyValuePairs("online[" + onlineIndex + "]");
				keyValuePairs.AddRange(onlineItems);
			}


			for(var strangersIndex = 0; strangersIndex<strangers.Count;strangersIndex++) 
			{
				var strangersItem = strangers[strangersIndex];
				var strangersItems = strangersItem.ToKeyValuePairs("strangers[" + strangersIndex + "]");
				keyValuePairs.AddRange(strangersItems);
			}

			return keyValuePairs;
		}

	}
}
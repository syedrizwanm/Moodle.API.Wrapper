using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ChatLatestMessagesModel : IModel 
	{
		public int chatnewlasttime {get;set;}
		public List<Message> messages {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("chatnewlasttime",prefix),chatnewlasttime.ToString()));

			for(var messagesIndex = 0; messagesIndex<messages.Count;messagesIndex++) 
			{
				var messagesItem = messages[messagesIndex];
				var messagesItems = messagesItem.ToKeyValuePairs("messages[" + messagesIndex + "]");
				keyValuePairs.AddRange(messagesItems);
			}


			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}
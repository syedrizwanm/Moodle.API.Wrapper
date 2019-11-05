using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SendInstantMessagesInputModel : IModel 
	{
		public List<MessageInputModel> messages {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var messagesIndex = 0; messagesIndex<messages.Count;messagesIndex++) 
			{
				var messagesItem = messages[messagesIndex];
				var messagesItems = messagesItem.ToKeyValuePairs("messages[" + messagesIndex + "]");
				keyValuePairs.AddRange(messagesItems);
			}

			return keyValuePairs;
		}

	}
}
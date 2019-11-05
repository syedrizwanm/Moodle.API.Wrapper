using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ChatsByCoursesModel : IModel 
	{
		public List<Chat> chats {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var chatsIndex = 0; chatsIndex<chats.Count;chatsIndex++) 
			{
				var chatsItem = chats[chatsIndex];
				var chatsItems = chatsItem.ToKeyValuePairs("chats[" + chatsIndex + "]");
				keyValuePairs.AddRange(chatsItems);
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
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DataForMessageareaMessagesModel : IModel 
	{
		public int currentuserid {get;set;}
		public int isblocked {get;set;}
		public int iscurrentuser {get;set;}
		public int isonline {get;set;}
		public List<Message> messages {get;set;}
		public string otheruserfullname {get;set;}
		public int otheruserid {get;set;}
		public int showonlinestatus {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("currentuserid",prefix),currentuserid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isblocked",prefix),isblocked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iscurrentuser",prefix),iscurrentuser.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isonline",prefix),isonline.ToString()));

			for(var messagesIndex = 0; messagesIndex<messages.Count;messagesIndex++) 
			{
				var messagesItem = messages[messagesIndex];
				var messagesItems = messagesItem.ToKeyValuePairs("messages[" + messagesIndex + "]");
				keyValuePairs.AddRange(messagesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("otheruserfullname",prefix),otheruserfullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("otheruserid",prefix),otheruserid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showonlinestatus",prefix),showonlinestatus.ToString()));
			return keyValuePairs;
		}

	}
}
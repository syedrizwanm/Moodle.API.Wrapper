using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ChatLatestMessagesInputModel : IModel 
	{
		public int chatlasttime {get;set;}
		public string chatsid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("chatlasttime",prefix),chatlasttime.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("chatsid",prefix),chatsid));
			return keyValuePairs;
		}

	}
}
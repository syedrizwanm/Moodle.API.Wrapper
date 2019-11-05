using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SendChatMessageInputModel : IModel 
	{
		public string beepid {get;set;}
		public string chatsid {get;set;}
		public string messagetext {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("beepid",prefix),beepid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("chatsid",prefix),chatsid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("messagetext",prefix),messagetext));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ChatUsersInputModel : IModel 
	{
		public string chatsid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("chatsid",prefix),chatsid));
			return keyValuePairs;
		}

	}
}
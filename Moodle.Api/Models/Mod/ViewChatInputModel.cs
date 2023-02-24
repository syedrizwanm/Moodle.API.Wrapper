using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewChatInputModel : IModel 
	{
		public int chatid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("chatid",prefix),chatid.ToString()));
			return keyValuePairs;
		}

	}
}
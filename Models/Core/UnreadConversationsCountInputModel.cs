using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UnreadConversationsCountInputModel : IModel 
	{
		public int useridto {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridto",prefix),useridto.ToString()));
			return keyValuePairs;
		}

	}
}
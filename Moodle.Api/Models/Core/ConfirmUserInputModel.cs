using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ConfirmUserInputModel : IModel 
	{
		public string secret {get;set;}
		public string username {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("secret",prefix),secret));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("username",prefix),username));
			return keyValuePairs;
		}

	}
}
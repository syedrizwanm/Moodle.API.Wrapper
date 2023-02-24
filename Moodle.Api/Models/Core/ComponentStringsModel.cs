using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ComponentStringsModel : IModel 
	{
		public string @string {get;set;}
		public string stringid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("@string",prefix),@string));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("stringid",prefix),stringid));
			return keyValuePairs;
		}

	}
}
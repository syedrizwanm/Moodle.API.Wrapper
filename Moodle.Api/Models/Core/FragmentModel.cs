using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class FragmentModel : IModel 
	{
		public string html {get;set;}
		public string javascript {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("html",prefix),html));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("javascript",prefix),javascript));
			return keyValuePairs;
		}

	}
}
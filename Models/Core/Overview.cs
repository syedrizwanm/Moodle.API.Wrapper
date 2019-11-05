using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Overview : IModel 
	{

		public string module {get;set;}
		public string overviewtext {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("module",prefix),module));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("overviewtext",prefix),overviewtext));
			return keyValuePairs;
		}

	}
}
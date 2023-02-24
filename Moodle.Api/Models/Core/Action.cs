using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Action : IModel 
	{

		public int actionable {get;set;}
		public int itemcount {get;set;}
		public string name {get;set;}
		public int showitemcount {get;set;}
		public string url {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("actionable",prefix),actionable.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemcount",prefix),itemcount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showitemcount",prefix),showitemcount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			return keyValuePairs;
		}

	}
}
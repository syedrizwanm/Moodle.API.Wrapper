using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class PagecontextInputModel : IModel 
	{

		public int contextid {get;set;}
		public string contextlevel {get;set;}
		public int instanceid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextlevel",prefix),contextlevel));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instanceid",prefix),instanceid.ToString()));
			return keyValuePairs;
		}

	}
}
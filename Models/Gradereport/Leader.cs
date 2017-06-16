using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Gradereport
{
	public sealed class Leader : IModel 
	{

		public string @class {get;set;}
		public int rowspan {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("@class",prefix),@class));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rowspan",prefix),rowspan.ToString()));
			return keyValuePairs;
		}

	}
}
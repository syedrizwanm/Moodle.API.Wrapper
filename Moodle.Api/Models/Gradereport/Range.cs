using System.Collections.Generic;

namespace Moodle.Api.Models.Gradereport
{
	public sealed class Range : IModel 
	{

		public string @class {get;set;}
		public string content {get;set;}
		public string headers {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("@class",prefix),@class));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content",prefix),content));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("headers",prefix),headers));
			return keyValuePairs;
		}

	}
}
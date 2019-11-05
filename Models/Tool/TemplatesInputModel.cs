using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class TemplatesInputModel : IModel 
	{
		public string component {get;set;}
		public string search {get;set;}
		public string themename {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("search",prefix),search));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("themename",prefix),themename));
			return keyValuePairs;
		}

	}
}
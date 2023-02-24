using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Icon : IModel 
	{

		public string alttext {get;set;}
		public string component {get;set;}
		public string key {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("alttext",prefix),alttext));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("key",prefix),key));
			return keyValuePairs;
		}

	}
}
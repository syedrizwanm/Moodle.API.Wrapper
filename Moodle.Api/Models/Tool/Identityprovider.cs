using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Identityprovider : IModel 
	{

		public string iconurl {get;set;}
		public string name {get;set;}
		public string url {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iconurl",prefix),iconurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			return keyValuePairs;
		}

	}
}
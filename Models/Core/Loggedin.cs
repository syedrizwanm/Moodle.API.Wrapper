using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Loggedin : IModel 
	{

		public int @checked {get;set;}
		public string displayname {get;set;}
		public string name {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("@checked",prefix),@checked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayname",prefix),displayname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			return keyValuePairs;
		}

	}
}
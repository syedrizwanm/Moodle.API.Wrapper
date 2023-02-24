using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Role : IModel 
	{

		public string name {get;set;}
		public int roleid {get;set;}
		public string shortname {get;set;}
		public int sortorder {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("roleid",prefix),roleid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortorder",prefix),sortorder.ToString()));
			return keyValuePairs;
		}

	}
}
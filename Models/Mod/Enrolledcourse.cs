using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Enrolledcourse : IModel 
	{

		public string fullname {get;set;}
		public int id {get;set;}
		public string shortname {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Subwiki : IModel 
	{

		public int canedit {get;set;}
		public string groupid {get;set;}
		public int id {get;set;}
		public int userid {get;set;}
		public int wikiid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canedit",prefix),canedit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("wikiid",prefix),wikiid.ToString()));
			return keyValuePairs;
		}

	}
}
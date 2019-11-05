using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class EntriesInputModel : IModel 
	{
		public int databaseid {get;set;}
		public int groupid {get;set;}
		public string order {get;set;}
		public int page {get;set;}
		public int perpage {get;set;}
		public int returncontents {get;set;}
		public int sort {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("databaseid",prefix),databaseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("order",prefix),order));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("page",prefix),page.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("perpage",prefix),perpage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("returncontents",prefix),returncontents.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sort",prefix),sort.ToString()));
			return keyValuePairs;
		}

	}
}
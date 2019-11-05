using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SearchEntriesInputModel : IModel 
	{
		public List<AdvsearchInputModel> advsearch {get;set;}
		public int databaseid {get;set;}
		public int groupid {get;set;}
		public string order {get;set;}
		public int page {get;set;}
		public int perpage {get;set;}
		public int returncontents {get;set;}
		public string search {get;set;}
		public int sort {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var advsearchIndex = 0; advsearchIndex<advsearch.Count;advsearchIndex++) 
			{
				var advsearchItem = advsearch[advsearchIndex];
				var advsearchItems = advsearchItem.ToKeyValuePairs("advsearch[" + advsearchIndex + "]");
				keyValuePairs.AddRange(advsearchItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("databaseid",prefix),databaseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("order",prefix),order));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("page",prefix),page.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("perpage",prefix),perpage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("returncontents",prefix),returncontents.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("search",prefix),search));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sort",prefix),sort.ToString()));
			return keyValuePairs;
		}

	}
}
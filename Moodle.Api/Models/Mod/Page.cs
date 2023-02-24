using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Page : IModel 
	{

		public int @readonly {get;set;}
		public string cachedcontent {get;set;}
		public int caneditpage {get;set;}
		public int contentformat {get;set;}
		public int contentsize {get;set;}
		public int firstpage {get;set;}
		public int id {get;set;}
		public int pageviews {get;set;}
		public int subwikiid {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int timerendered {get;set;}
		public string title {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("@readonly",prefix),@readonly.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cachedcontent",prefix),cachedcontent));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("caneditpage",prefix),caneditpage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contentformat",prefix),contentformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contentsize",prefix),contentsize.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("firstpage",prefix),firstpage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pageviews",prefix),pageviews.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("subwikiid",prefix),subwikiid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timerendered",prefix),timerendered.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("title",prefix),title));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
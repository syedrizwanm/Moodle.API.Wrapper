using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class TagindexModel : IModel 
	{
		public string anchor {get;set;}
		public string component {get;set;}
		public string content {get;set;}
		public string exclusivetext {get;set;}
		public string exclusiveurl {get;set;}
		public int hascontent {get;set;}
		public string itemtype {get;set;}
		public string nextpageurl {get;set;}
		public string prevpageurl {get;set;}
		public int ta {get;set;}
		public int tagid {get;set;}
		public string title {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("anchor",prefix),anchor));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content",prefix),content));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("exclusivetext",prefix),exclusivetext));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("exclusiveurl",prefix),exclusiveurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hascontent",prefix),hascontent.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemtype",prefix),itemtype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("nextpageurl",prefix),nextpageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("prevpageurl",prefix),prevpageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ta",prefix),ta.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("tagid",prefix),tagid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("title",prefix),title));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class TagindexInputModelClass : IModel 
	{

		public int ctx {get;set;}
		public int excl {get;set;}
		public int from {get;set;}
		public int page {get;set;}
		public int rec {get;set;}
		public int ta {get;set;}
		public string tag {get;set;}
		public int tc {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ctx",prefix),ctx.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("excl",prefix),excl.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("from",prefix),from.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("page",prefix),page.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rec",prefix),rec.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ta",prefix),ta.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("tag",prefix),tag));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("tc",prefix),tc.ToString()));
			return keyValuePairs;
		}

	}
}
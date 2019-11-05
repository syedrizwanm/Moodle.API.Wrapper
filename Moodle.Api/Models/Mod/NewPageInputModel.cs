using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class NewPageInputModel : IModel 
	{
		public string content {get;set;}
		public string contentformat {get;set;}
		public int groupid {get;set;}
		public int subwikiid {get;set;}
		public string title {get;set;}
		public int userid {get;set;}
		public int wikiid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content",prefix),content));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contentformat",prefix),contentformat));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("subwikiid",prefix),subwikiid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("title",prefix),title));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("wikiid",prefix),wikiid.ToString()));
			return keyValuePairs;
		}

	}
}
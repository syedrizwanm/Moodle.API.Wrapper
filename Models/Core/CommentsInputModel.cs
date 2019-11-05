using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CommentsInputModel : IModel 
	{
		public string area {get;set;}
		public string component {get;set;}
		public string contextlevel {get;set;}
		public int instanceid {get;set;}
		public int itemid {get;set;}
		public int page {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("area",prefix),area));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextlevel",prefix),contextlevel));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instanceid",prefix),instanceid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("page",prefix),page.ToString()));
			return keyValuePairs;
		}

	}
}
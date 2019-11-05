using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class SearchCohortsInputModel : IModel 
	{
		public ContextInputModel context {get;set;}
		public string includes {get;set;}
		public int limitfrom {get;set;}
		public int limitnum {get;set;}
		public string query {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var contextItems = context.ToKeyValuePairs("context");
			keyValuePairs.AddRange(contextItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includes",prefix),includes));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitfrom",prefix),limitfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitnum",prefix),limitnum.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("query",prefix),query));
			return keyValuePairs;
		}

	}
}
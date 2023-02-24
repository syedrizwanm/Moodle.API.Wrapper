using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CompetencyFrameworksInputModel : IModel 
	{
		public ContextInputModel context {get;set;}
		public string includes {get;set;}
		public int limit {get;set;}
		public int onlyvisible {get;set;}
		public string order {get;set;}
		public string query {get;set;}
		public int skip {get;set;}
		public string sort {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var contextItems = context.ToKeyValuePairs("context");
			keyValuePairs.AddRange(contextItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includes",prefix),includes));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limit",prefix),limit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("onlyvisible",prefix),onlyvisible.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("order",prefix),order));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("query",prefix),query));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("skip",prefix),skip.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sort",prefix),sort));
			return keyValuePairs;
		}

	}
}
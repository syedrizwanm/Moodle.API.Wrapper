using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ParticipantsInputModel : IModel 
	{
		public int assignid {get;set;}
		public string filter {get;set;}
		public int groupid {get;set;}
		public int includeenrolments {get;set;}
		public int limit {get;set;}
		public int onlyids {get;set;}
		public int skip {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignid",prefix),assignid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filter",prefix),filter));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includeenrolments",prefix),includeenrolments.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limit",prefix),limit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("onlyids",prefix),onlyids.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("skip",prefix),skip.ToString()));
			return keyValuePairs;
		}

	}
}
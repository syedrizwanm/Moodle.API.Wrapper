using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ResponsesAnalysisInputModel : IModel 
	{
		public int feedbackid {get;set;}
		public int groupid {get;set;}
		public int page {get;set;}
		public int perpage {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedbackid",prefix),feedbackid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("page",prefix),page.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("perpage",prefix),perpage.ToString()));
			return keyValuePairs;
		}

	}
}
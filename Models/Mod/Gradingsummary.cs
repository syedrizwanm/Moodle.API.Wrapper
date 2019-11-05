using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Gradingsummary : IModel 
	{

		public int participantcount {get;set;}
		public int submissiondraftscount {get;set;}
		public int submissionsenabled {get;set;}
		public int submissionsneedgradingcount {get;set;}
		public int submissionssubmittedcount {get;set;}
		public int warnofungroupedusers {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("participantcount",prefix),participantcount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("submissiondraftscount",prefix),submissiondraftscount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("submissionsenabled",prefix),submissionsenabled.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("submissionsneedgradingcount",prefix),submissionsneedgradingcount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("submissionssubmittedcount",prefix),submissionssubmittedcount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("warnofungroupedusers",prefix),warnofungroupedusers.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForCompetencySummaryInputModel : IModel 
	{
		public int competencyid {get;set;}
		public int includecourses {get;set;}
		public int includerelated {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyid",prefix),competencyid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includecourses",prefix),includecourses.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includerelated",prefix),includerelated.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForCourseCompetenciesPageModel : IModel 
	{
		public int canconfigurecoursecompetencies {get;set;}
		public int cangradecompetencies {get;set;}
		public int canmanagecompetencyframeworks {get;set;}
		public int canmanagecoursecompetencies {get;set;}
		public List<Competencie> competencies {get;set;}
		public int courseid {get;set;}
		public int gradableuserid {get;set;}
		public string manageurl {get;set;}
		public int pagecontextid {get;set;}
		public Setting settings {get;set;}
		public Statistic statistics {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canconfigurecoursecompetencies",prefix),canconfigurecoursecompetencies.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cangradecompetencies",prefix),cangradecompetencies.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanagecompetencyframeworks",prefix),canmanagecompetencyframeworks.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanagecoursecompetencies",prefix),canmanagecoursecompetencies.ToString()));

			for(var competenciesIndex = 0; competenciesIndex<competencies.Count;competenciesIndex++) 
			{
				var competenciesItem = competencies[competenciesIndex];
				var competenciesItems = competenciesItem.ToKeyValuePairs("competencies[" + competenciesIndex + "]");
				keyValuePairs.AddRange(competenciesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradableuserid",prefix),gradableuserid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("manageurl",prefix),manageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pagecontextid",prefix),pagecontextid.ToString()));
			var settingsItems = settings.ToKeyValuePairs("settings");
			keyValuePairs.AddRange(settingsItems);
			var statisticsItems = statistics.ToKeyValuePairs("statistics");
			keyValuePairs.AddRange(statisticsItems);
			return keyValuePairs;
		}

	}
}
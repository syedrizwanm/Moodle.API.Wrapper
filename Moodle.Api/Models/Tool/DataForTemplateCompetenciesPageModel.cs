using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForTemplateCompetenciesPageModel : IModel 
	{
		public int canmanagecompetencyframeworks {get;set;}
		public int canmanagetemplatecompetencies {get;set;}
		public List<Competencie> competencies {get;set;}
		public string manageurl {get;set;}
		public int pagecontextid {get;set;}
		public string pluginbaseurl {get;set;}
		public Statistic statistics {get;set;}
		public Template template {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanagecompetencyframeworks",prefix),canmanagecompetencyframeworks.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanagetemplatecompetencies",prefix),canmanagetemplatecompetencies.ToString()));

			for(var competenciesIndex = 0; competenciesIndex<competencies.Count;competenciesIndex++) 
			{
				var competenciesItem = competencies[competenciesIndex];
				var competenciesItems = competenciesItem.ToKeyValuePairs("competencies[" + competenciesIndex + "]");
				keyValuePairs.AddRange(competenciesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("manageurl",prefix),manageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pagecontextid",prefix),pagecontextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pluginbaseurl",prefix),pluginbaseurl));
			var statisticsItems = statistics.ToKeyValuePairs("statistics");
			keyValuePairs.AddRange(statisticsItems);
			var templateItems = template.ToKeyValuePairs("template");
			keyValuePairs.AddRange(templateItems);
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForPlanPageModel : IModel 
	{
		public List<Competencie> competencies {get;set;}
		public int competencycount {get;set;}
		public int contextid {get;set;}
		public Plan plan {get;set;}
		public string pluginbaseurl {get;set;}
		public int proficientcompetencycount {get;set;}
		public double proficientcompetencypercentage {get;set;}
		public string proficientcompetencypercentageformatted {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var competenciesIndex = 0; competenciesIndex<competencies.Count;competenciesIndex++) 
			{
				var competenciesItem = competencies[competenciesIndex];
				var competenciesItems = competenciesItem.ToKeyValuePairs("competencies[" + competenciesIndex + "]");
				keyValuePairs.AddRange(competenciesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencycount",prefix),competencycount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			var planItems = plan.ToKeyValuePairs("plan");
			keyValuePairs.AddRange(planItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pluginbaseurl",prefix),pluginbaseurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("proficientcompetencycount",prefix),proficientcompetencycount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("proficientcompetencypercentage",prefix),proficientcompetencypercentage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("proficientcompetencypercentageformatted",prefix),proficientcompetencypercentageformatted));
			return keyValuePairs;
		}

	}
}
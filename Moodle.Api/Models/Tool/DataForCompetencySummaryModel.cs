using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForCompetencySummaryModel : IModel 
	{
		public Competency competency {get;set;}
		public Comppath comppath {get;set;}
		public Framework framework {get;set;}
		public int hascourses {get;set;}
		public int hasrelatedcompetencies {get;set;}
		public List<Linkedcourse> linkedcourses {get;set;}
		public List<Relatedcompetencie> relatedcompetencies {get;set;}
		public string scaleconfiguration {get;set;}
		public int scaleid {get;set;}
		public string taxonomyterm {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var competencyItems = competency.ToKeyValuePairs("competency");
			keyValuePairs.AddRange(competencyItems);
			var comppathItems = comppath.ToKeyValuePairs("comppath");
			keyValuePairs.AddRange(comppathItems);
			var frameworkItems = framework.ToKeyValuePairs("framework");
			keyValuePairs.AddRange(frameworkItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hascourses",prefix),hascourses.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hasrelatedcompetencies",prefix),hasrelatedcompetencies.ToString()));

			for(var linkedcoursesIndex = 0; linkedcoursesIndex<linkedcourses.Count;linkedcoursesIndex++) 
			{
				var linkedcoursesItem = linkedcourses[linkedcoursesIndex];
				var linkedcoursesItems = linkedcoursesItem.ToKeyValuePairs("linkedcourses[" + linkedcoursesIndex + "]");
				keyValuePairs.AddRange(linkedcoursesItems);
			}


			for(var relatedcompetenciesIndex = 0; relatedcompetenciesIndex<relatedcompetencies.Count;relatedcompetenciesIndex++) 
			{
				var relatedcompetenciesItem = relatedcompetencies[relatedcompetenciesIndex];
				var relatedcompetenciesItems = relatedcompetenciesItem.ToKeyValuePairs("relatedcompetencies[" + relatedcompetenciesIndex + "]");
				keyValuePairs.AddRange(relatedcompetenciesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleconfiguration",prefix),scaleconfiguration));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleid",prefix),scaleid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("taxonomyterm",prefix),taxonomyterm));
			return keyValuePairs;
		}

	}
}
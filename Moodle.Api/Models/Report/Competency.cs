using System.Collections.Generic;

namespace Moodle.Api.Models.Report
{
	public sealed class Competency : IModel 
	{

		public Competency competency {get;set;}
		public int competencyframeworkid {get;set;}
		public Comppath comppath {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public Framework framework {get;set;}
		public int hascourses {get;set;}
		public int hasrelatedcompetencies {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public List<Linkedcourse> linkedcourses {get;set;}
		public int parentid {get;set;}
		public string path {get;set;}
		public List<Relatedcompetencie> relatedcompetencies {get;set;}
		public string ruleconfig {get;set;}
		public int ruleoutcome {get;set;}
		public string ruletype {get;set;}
		public string scaleconfiguration {get;set;}
		public int scaleid {get;set;}
		public string shortname {get;set;}
		public int sortorder {get;set;}
		public string taxonomyterm {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int usermodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var competencyItems = competency.ToKeyValuePairs("competency");
			keyValuePairs.AddRange(competencyItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyframeworkid",prefix),competencyframeworkid.ToString()));
			var comppathItems = comppath.ToKeyValuePairs("comppath");
			keyValuePairs.AddRange(comppathItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			var frameworkItems = framework.ToKeyValuePairs("framework");
			keyValuePairs.AddRange(frameworkItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hascourses",prefix),hascourses.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hasrelatedcompetencies",prefix),hasrelatedcompetencies.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber));

			for(var linkedcoursesIndex = 0; linkedcoursesIndex<linkedcourses.Count;linkedcoursesIndex++) 
			{
				var linkedcoursesItem = linkedcourses[linkedcoursesIndex];
				var linkedcoursesItems = linkedcoursesItem.ToKeyValuePairs("linkedcourses[" + linkedcoursesIndex + "]");
				keyValuePairs.AddRange(linkedcoursesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("parentid",prefix),parentid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("path",prefix),path));

			for(var relatedcompetenciesIndex = 0; relatedcompetenciesIndex<relatedcompetencies.Count;relatedcompetenciesIndex++) 
			{
				var relatedcompetenciesItem = relatedcompetencies[relatedcompetenciesIndex];
				var relatedcompetenciesItems = relatedcompetenciesItem.ToKeyValuePairs("relatedcompetencies[" + relatedcompetenciesIndex + "]");
				keyValuePairs.AddRange(relatedcompetenciesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ruleconfig",prefix),ruleconfig));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ruleoutcome",prefix),ruleoutcome.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ruletype",prefix),ruletype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleconfiguration",prefix),scaleconfiguration));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleid",prefix),scaleid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortorder",prefix),sortorder.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("taxonomyterm",prefix),taxonomyterm));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			return keyValuePairs;
		}

	}
}
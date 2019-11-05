using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Cm : IModel 
	{

		public int added {get;set;}
		public List<Advancedgrading> advancedgrading {get;set;}
		public string availability {get;set;}
		public int completion {get;set;}
		public int completionexpected {get;set;}
		public int completiongradeitemnumber {get;set;}
		public int completionview {get;set;}
		public int course {get;set;}
		public int grade {get;set;}
		public int gradecat {get;set;}
		public string gradepass {get;set;}
		public int groupingid {get;set;}
		public int groupmode {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public int indent {get;set;}
		public int instance {get;set;}
		public string modname {get;set;}
		public int module {get;set;}
		public string name {get;set;}
		public List<Outcome> outcomes {get;set;}
		public string scale {get;set;}
		public int score {get;set;}
		public int section {get;set;}
		public int sectionnum {get;set;}
		public int showdescription {get;set;}
		public int visible {get;set;}
		public int visibleold {get;set;}
		public int visibleoncoursepage {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("added",prefix),added.ToString()));

			for(var advancedgradingIndex = 0; advancedgradingIndex<advancedgrading.Count;advancedgradingIndex++) 
			{
				var advancedgradingItem = advancedgrading[advancedgradingIndex];
				var advancedgradingItems = advancedgradingItem.ToKeyValuePairs("advancedgrading[" + advancedgradingIndex + "]");
				keyValuePairs.AddRange(advancedgradingItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("availability",prefix),availability));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completion",prefix),completion.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionexpected",prefix),completionexpected.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completiongradeitemnumber",prefix),completiongradeitemnumber.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionview",prefix),completionview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradecat",prefix),gradecat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradepass",prefix),gradepass));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupingid",prefix),groupingid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupmode",prefix),groupmode.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("indent",prefix),indent.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instance",prefix),instance.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("modname",prefix),modname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("module",prefix),module.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));

			for(var outcomesIndex = 0; outcomesIndex<outcomes.Count;outcomesIndex++) 
			{
				var outcomesItem = outcomes[outcomesIndex];
				var outcomesItems = outcomesItem.ToKeyValuePairs("outcomes[" + outcomesIndex + "]");
				keyValuePairs.AddRange(outcomesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scale",prefix),scale));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("score",prefix),score.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sectionnum",prefix),sectionnum.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showdescription",prefix),showdescription.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visibleold",prefix),visibleold.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visibleoncoursepage",prefix),visibleoncoursepage.ToString()));
			return keyValuePairs;
		}

	}
}
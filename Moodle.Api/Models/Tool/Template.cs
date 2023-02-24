using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Template : IModel 
	{

		public int canmanage {get;set;}
		public int canread {get;set;}
		public int cohortscount {get;set;}
		public int contextid {get;set;}
		public string contextname {get;set;}
		public string contextnamenoprefix {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public int duedate {get;set;}
		public string duedateformatted {get;set;}
		public int id {get;set;}
		public int planscount {get;set;}
		public string shortname {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int usermodified {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanage",prefix),canmanage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canread",prefix),canread.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cohortscount",prefix),cohortscount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextname",prefix),contextname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextnamenoprefix",prefix),contextnamenoprefix));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("duedate",prefix),duedate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("duedateformatted",prefix),duedateformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("planscount",prefix),planscount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
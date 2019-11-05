using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CoursInputModel : IModel 
	{

		public int categoryid {get;set;}
		public int completionnotify {get;set;}
		public List<CourseformatoptionInputModel> courseformatoptions {get;set;}
		public int defaultgroupingid {get;set;}
		public int enablecompletion {get;set;}
		public int enddate {get;set;}
		public string forcetheme {get;set;}
		public string format {get;set;}
		public string fullname {get;set;}
		public int groupmode {get;set;}
		public int groupmodeforce {get;set;}
		public int hiddensections {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public string lang {get;set;}
		public int maxbytes {get;set;}
		public int newsitems {get;set;}
		public int numsections {get;set;}
		public string shortname {get;set;}
		public int showgrades {get;set;}
		public int showreports {get;set;}
		public int startdate {get;set;}
		public string summary {get;set;}
		public int summaryformat {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("categoryid",prefix),categoryid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionnotify",prefix),completionnotify.ToString()));

			for(var courseformatoptionsIndex = 0; courseformatoptionsIndex<courseformatoptions.Count;courseformatoptionsIndex++) 
			{
				var courseformatoptionsItem = courseformatoptions[courseformatoptionsIndex];
				var courseformatoptionsItems = courseformatoptionsItem.ToKeyValuePairs("courseformatoptions[" + courseformatoptionsIndex + "]");
				keyValuePairs.AddRange(courseformatoptionsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("defaultgroupingid",prefix),defaultgroupingid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enablecompletion",prefix),enablecompletion.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enddate",prefix),enddate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("forcetheme",prefix),forcetheme));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("format",prefix),format));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupmode",prefix),groupmode.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupmodeforce",prefix),groupmodeforce.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hiddensections",prefix),hiddensections.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lang",prefix),lang));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxbytes",prefix),maxbytes.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("newsitems",prefix),newsitems.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("numsections",prefix),numsections.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showgrades",prefix),showgrades.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showreports",prefix),showreports.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("startdate",prefix),startdate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summary",prefix),summary));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summaryformat",prefix),summaryformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
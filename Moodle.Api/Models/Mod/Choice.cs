using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Choice : IModel 
	{

		public int allowmultiple {get;set;}
		public int allowupdate {get;set;}
		public int completionsubmit {get;set;}
		public int course {get;set;}
		public int coursemodule {get;set;}
		public int display {get;set;}
		public int groupingid {get;set;}
		public int groupmode {get;set;}
		public int id {get;set;}
		public int includeinactive {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public int limitanswers {get;set;}
		public string name {get;set;}
		public int publish {get;set;}
		public int section {get;set;}
		public int showpreview {get;set;}
		public int showresults {get;set;}
		public int showunanswered {get;set;}
		public int timeclose {get;set;}
		public int timemodified {get;set;}
		public int timeopen {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("allowmultiple",prefix),allowmultiple.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("allowupdate",prefix),allowupdate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionsubmit",prefix),completionsubmit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursemodule",prefix),coursemodule.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("display",prefix),display.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupingid",prefix),groupingid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupmode",prefix),groupmode.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includeinactive",prefix),includeinactive.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("intro",prefix),intro));

			for(var introfilesIndex = 0; introfilesIndex<introfiles.Count;introfilesIndex++) 
			{
				var introfilesItem = introfiles[introfilesIndex];
				var introfilesItems = introfilesItem.ToKeyValuePairs("introfiles[" + introfilesIndex + "]");
				keyValuePairs.AddRange(introfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("introformat",prefix),introformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitanswers",prefix),limitanswers.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("publish",prefix),publish.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showpreview",prefix),showpreview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showresults",prefix),showresults.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showunanswered",prefix),showunanswered.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeclose",prefix),timeclose.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeopen",prefix),timeopen.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
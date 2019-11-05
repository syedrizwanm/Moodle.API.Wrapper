using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Glossarie : IModel 
	{

		public int allowcomments {get;set;}
		public int allowduplicatedentries {get;set;}
		public int allowprintview {get;set;}
		public string approvaldisplayformat {get;set;}
		public int assessed {get;set;}
		public int assesstimefinish {get;set;}
		public int assesstimestart {get;set;}
		public List<string> browsemodes {get;set;}
		public int canaddentry {get;set;}
		public int completionentries {get;set;}
		public int course {get;set;}
		public int coursemodule {get;set;}
		public int defaultapproval {get;set;}
		public string displayformat {get;set;}
		public int editalways {get;set;}
		public int entbypage {get;set;}
		public int globalglossary {get;set;}
		public int groupingid {get;set;}
		public int groupmode {get;set;}
		public int id {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public int mainglossary {get;set;}
		public string name {get;set;}
		public int rssarticles {get;set;}
		public int rsstype {get;set;}
		public int scale {get;set;}
		public int section {get;set;}
		public int showall {get;set;}
		public int showalphabet {get;set;}
		public int showspecial {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int usedynalink {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("allowcomments",prefix),allowcomments.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("allowduplicatedentries",prefix),allowduplicatedentries.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("allowprintview",prefix),allowprintview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("approvaldisplayformat",prefix),approvaldisplayformat));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assessed",prefix),assessed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assesstimefinish",prefix),assesstimefinish.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assesstimestart",prefix),assesstimestart.ToString()));

			for(var browsemodesIndex = 0; browsemodesIndex<browsemodes.Count;browsemodesIndex++) 
			{
				var browsemodesItem = browsemodes[browsemodesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("browsemodes[" + browsemodesIndex + "]",prefix), browsemodesItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canaddentry",prefix),canaddentry.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completionentries",prefix),completionentries.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursemodule",prefix),coursemodule.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("defaultapproval",prefix),defaultapproval.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayformat",prefix),displayformat));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("editalways",prefix),editalways.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("entbypage",prefix),entbypage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("globalglossary",prefix),globalglossary.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupingid",prefix),groupingid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupmode",prefix),groupmode.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("intro",prefix),intro));

			for(var introfilesIndex = 0; introfilesIndex<introfiles.Count;introfilesIndex++) 
			{
				var introfilesItem = introfiles[introfilesIndex];
				var introfilesItems = introfilesItem.ToKeyValuePairs("introfiles[" + introfilesIndex + "]");
				keyValuePairs.AddRange(introfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("introformat",prefix),introformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mainglossary",prefix),mainglossary.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rssarticles",prefix),rssarticles.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rsstype",prefix),rsstype.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scale",prefix),scale.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showall",prefix),showall.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showalphabet",prefix),showalphabet.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showspecial",prefix),showspecial.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usedynalink",prefix),usedynalink.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
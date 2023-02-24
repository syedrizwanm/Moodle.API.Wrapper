using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Book : IModel 
	{

		public int course {get;set;}
		public int coursemodule {get;set;}
		public int customtitles {get;set;}
		public int groupingid {get;set;}
		public int groupmode {get;set;}
		public int id {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public string name {get;set;}
		public int navstyle {get;set;}
		public int numbering {get;set;}
		public int revision {get;set;}
		public int section {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursemodule",prefix),coursemodule.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("customtitles",prefix),customtitles.ToString()));
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
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("navstyle",prefix),navstyle.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("numbering",prefix),numbering.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("revision",prefix),revision.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
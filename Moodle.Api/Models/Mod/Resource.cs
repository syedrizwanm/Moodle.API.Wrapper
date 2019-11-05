using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Resource : IModel 
	{

		public List<Contentfile> contentfiles {get;set;}
		public int course {get;set;}
		public int coursemodule {get;set;}
		public int display {get;set;}
		public string displayoptions {get;set;}
		public int filterfiles {get;set;}
		public int groupingid {get;set;}
		public int groupmode {get;set;}
		public int id {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public int legacyfiles {get;set;}
		public int legacyfileslast {get;set;}
		public string name {get;set;}
		public int revision {get;set;}
		public int section {get;set;}
		public int timemodified {get;set;}
		public int tobemigrated {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var contentfilesIndex = 0; contentfilesIndex<contentfiles.Count;contentfilesIndex++) 
			{
				var contentfilesItem = contentfiles[contentfilesIndex];
				var contentfilesItems = contentfilesItem.ToKeyValuePairs("contentfiles[" + contentfilesIndex + "]");
				keyValuePairs.AddRange(contentfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursemodule",prefix),coursemodule.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("display",prefix),display.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayoptions",prefix),displayoptions));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filterfiles",prefix),filterfiles.ToString()));
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
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("legacyfiles",prefix),legacyfiles.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("legacyfileslast",prefix),legacyfileslast.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("revision",prefix),revision.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("tobemigrated",prefix),tobemigrated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
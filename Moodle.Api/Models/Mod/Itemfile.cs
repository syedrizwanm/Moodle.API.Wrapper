using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Itemfile : IModel 
	{

		public string author {get;set;}
		public string component {get;set;}
		public int contextid {get;set;}
		public string filearea {get;set;}
		public string filename {get;set;}
		public string filenameshort {get;set;}
		public string filepath {get;set;}
		public int filesize {get;set;}
		public string filesizeformatted {get;set;}
		public string icon {get;set;}
		public int isdir {get;set;}
		public int itemid {get;set;}
		public string license {get;set;}
		public int timecreated {get;set;}
		public string timecreatedformatted {get;set;}
		public int timemodified {get;set;}
		public string timemodifiedformatted {get;set;}
		public string url {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("author",prefix),author));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filearea",prefix),filearea));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filename",prefix),filename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filenameshort",prefix),filenameshort));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filepath",prefix),filepath));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filesize",prefix),filesize.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filesizeformatted",prefix),filesizeformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("icon",prefix),icon));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isdir",prefix),isdir.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("license",prefix),license));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreatedformatted",prefix),timecreatedformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodifiedformatted",prefix),timemodifiedformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			return keyValuePairs;
		}

	}
}
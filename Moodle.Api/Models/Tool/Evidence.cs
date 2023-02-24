using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Evidence : IModel 
	{

		public int canmanage {get;set;}
		public int competencycount {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public int filecount {get;set;}
		public List<File> files {get;set;}
		public int hasurlorfiles {get;set;}
		public int id {get;set;}
		public string name {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public string url {get;set;}
		public string urlshort {get;set;}
		public List<Usercompetencie> usercompetencies {get;set;}
		public int userhasplan {get;set;}
		public int userid {get;set;}
		public int usermodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanage",prefix),canmanage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencycount",prefix),competencycount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filecount",prefix),filecount.ToString()));

			for(var filesIndex = 0; filesIndex<files.Count;filesIndex++) 
			{
				var filesItem = files[filesIndex];
				var filesItems = filesItem.ToKeyValuePairs("files[" + filesIndex + "]");
				keyValuePairs.AddRange(filesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hasurlorfiles",prefix),hasurlorfiles.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("urlshort",prefix),urlshort));

			for(var usercompetenciesIndex = 0; usercompetenciesIndex<usercompetencies.Count;usercompetenciesIndex++) 
			{
				var usercompetenciesItem = usercompetencies[usercompetenciesIndex];
				var usercompetenciesItems = usercompetenciesItem.ToKeyValuePairs("usercompetencies[" + usercompetenciesIndex + "]");
				keyValuePairs.AddRange(usercompetenciesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userhasplan",prefix),userhasplan.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			return keyValuePairs;
		}

	}
}
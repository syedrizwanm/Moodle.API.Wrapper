using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Database : IModel 
	{

		public string addtemplate {get;set;}
		public int approval {get;set;}
		public string asearchtemplate {get;set;}
		public int assessed {get;set;}
		public int assesstimefinish {get;set;}
		public int assesstimestart {get;set;}
		public int comments {get;set;}
		public int course {get;set;}
		public int coursemodule {get;set;}
		public string csstemplate {get;set;}
		public int defaultsort {get;set;}
		public int defaultsortdir {get;set;}
		public int editany {get;set;}
		public int id {get;set;}
		public string intro {get;set;}
		public List<Introfile> introfiles {get;set;}
		public int introformat {get;set;}
		public string jstemplate {get;set;}
		public string listtemplate {get;set;}
		public string listtemplatefooter {get;set;}
		public string listtemplateheader {get;set;}
		public int manageapproved {get;set;}
		public int maxentries {get;set;}
		public string name {get;set;}
		public int notification {get;set;}
		public int requiredentries {get;set;}
		public int requiredentriestoview {get;set;}
		public int rssarticles {get;set;}
		public string rsstemplate {get;set;}
		public string rsstitletemplate {get;set;}
		public int scale {get;set;}
		public string singletemplate {get;set;}
		public int timeavailablefrom {get;set;}
		public int timeavailableto {get;set;}
		public int timemodified {get;set;}
		public int timeviewfrom {get;set;}
		public int timeviewto {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("addtemplate",prefix),addtemplate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("approval",prefix),approval.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("asearchtemplate",prefix),asearchtemplate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assessed",prefix),assessed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assesstimefinish",prefix),assesstimefinish.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assesstimestart",prefix),assesstimestart.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("comments",prefix),comments.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("course",prefix),course.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursemodule",prefix),coursemodule.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("csstemplate",prefix),csstemplate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("defaultsort",prefix),defaultsort.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("defaultsortdir",prefix),defaultsortdir.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("editany",prefix),editany.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("intro",prefix),intro));

			for(var introfilesIndex = 0; introfilesIndex<introfiles.Count;introfilesIndex++) 
			{
				var introfilesItem = introfiles[introfilesIndex];
				var introfilesItems = introfilesItem.ToKeyValuePairs("introfiles[" + introfilesIndex + "]");
				keyValuePairs.AddRange(introfilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("introformat",prefix),introformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("jstemplate",prefix),jstemplate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("listtemplate",prefix),listtemplate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("listtemplatefooter",prefix),listtemplatefooter));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("listtemplateheader",prefix),listtemplateheader));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("manageapproved",prefix),manageapproved.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxentries",prefix),maxentries.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("notification",prefix),notification.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("requiredentries",prefix),requiredentries.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("requiredentriestoview",prefix),requiredentriestoview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rssarticles",prefix),rssarticles.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rsstemplate",prefix),rsstemplate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rsstitletemplate",prefix),rsstitletemplate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scale",prefix),scale.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("singletemplate",prefix),singletemplate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeavailablefrom",prefix),timeavailablefrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeavailableto",prefix),timeavailableto.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeviewfrom",prefix),timeviewfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeviewto",prefix),timeviewto.ToString()));
			return keyValuePairs;
		}

	}
}
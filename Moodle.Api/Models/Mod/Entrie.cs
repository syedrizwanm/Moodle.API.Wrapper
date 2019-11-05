using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Entrie : IModel 
	{

		public int approved {get;set;}
		public int canmanageentry {get;set;}
		public List<Content> contents {get;set;}
		public int dataid {get;set;}
		public string fullname {get;set;}
		public int groupid {get;set;}
		public int id {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("approved",prefix),approved.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanageentry",prefix),canmanageentry.ToString()));

			for(var contentsIndex = 0; contentsIndex<contents.Count;contentsIndex++) 
			{
				var contentsItem = contents[contentsIndex];
				var contentsItems = contentsItem.ToKeyValuePairs("contents[" + contentsIndex + "]");
				keyValuePairs.AddRange(contentsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dataid",prefix),dataid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
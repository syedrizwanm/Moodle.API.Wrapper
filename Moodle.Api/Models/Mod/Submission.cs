using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Submission : IModel 
	{

		public int assignment {get;set;}
		public int attemptnumber {get;set;}
		public string gradingstatus {get;set;}
		public int groupid {get;set;}
		public int id {get;set;}
		public int latest {get;set;}
		public List<Plugin> plugins {get;set;}
		public string status {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignment",prefix),assignment.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attemptnumber",prefix),attemptnumber.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradingstatus",prefix),gradingstatus));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("latest",prefix),latest.ToString()));

			for(var pluginsIndex = 0; pluginsIndex<plugins.Count;pluginsIndex++) 
			{
				var pluginsItem = plugins[pluginsIndex];
				var pluginsItems = pluginsItem.ToKeyValuePairs("plugins[" + pluginsIndex + "]");
				keyValuePairs.AddRange(pluginsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
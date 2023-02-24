using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class PlanInputModelClass : IModel 
	{

		public string description {get;set;}
		public int descriptionformat {get;set;}
		public int duedate {get;set;}
		public int id {get;set;}
		public string name {get;set;}
		public int origtemplateid {get;set;}
		public int reviewerid {get;set;}
		public int status {get;set;}
		public int templateid {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int userid {get;set;}
		public int usermodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("duedate",prefix),duedate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("origtemplateid",prefix),origtemplateid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewerid",prefix),reviewerid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("templateid",prefix),templateid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Message
{
	public sealed class Device : IModel 
	{

		public string appid {get;set;}
		public int enable {get;set;}
		public int id {get;set;}
		public string model {get;set;}
		public string name {get;set;}
		public string platform {get;set;}
		public string pushid {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public string uuid {get;set;}
		public string version {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("appid",prefix),appid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enable",prefix),enable.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("model",prefix),model));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("platform",prefix),platform));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pushid",prefix),pushid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("uuid",prefix),uuid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("version",prefix),version));
			return keyValuePairs;
		}

	}
}
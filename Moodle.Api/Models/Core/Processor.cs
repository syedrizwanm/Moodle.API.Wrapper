using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Processor : IModel 
	{

		public int contextid {get;set;}
		public string displayname {get;set;}
		public int hassettings {get;set;}
		public int locked {get;set;}
		public Loggedin loggedin {get;set;}
		public Loggedoff loggedoff {get;set;}
		public string name {get;set;}
		public int userconfigured {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayname",prefix),displayname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hassettings",prefix),hassettings.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("locked",prefix),locked.ToString()));
			var loggedinItems = loggedin.ToKeyValuePairs("loggedin");
			keyValuePairs.AddRange(loggedinItems);
			var loggedoffItems = loggedoff.ToKeyValuePairs("loggedoff");
			keyValuePairs.AddRange(loggedoffItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userconfigured",prefix),userconfigured.ToString()));
			return keyValuePairs;
		}

	}
}
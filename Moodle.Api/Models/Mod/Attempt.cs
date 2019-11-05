using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Attempt : IModel 
	{

		public int attempt {get;set;}
		public int currentpage {get;set;}
		public int id {get;set;}
		public string layout {get;set;}
		public int preview {get;set;}
		public int quiz {get;set;}
		public string state {get;set;}
		public double sumgrades {get;set;}
		public int timecheckstate {get;set;}
		public int timefinish {get;set;}
		public int timemodified {get;set;}
		public int timemodifiedoffline {get;set;}
		public int timestart {get;set;}
		public int uniqueid {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attempt",prefix),attempt.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("currentpage",prefix),currentpage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("layout",prefix),layout));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("preview",prefix),preview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("quiz",prefix),quiz.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("state",prefix),state));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sumgrades",prefix),sumgrades.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecheckstate",prefix),timecheckstate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timefinish",prefix),timefinish.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodifiedoffline",prefix),timemodifiedoffline.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timestart",prefix),timestart.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("uniqueid",prefix),uniqueid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
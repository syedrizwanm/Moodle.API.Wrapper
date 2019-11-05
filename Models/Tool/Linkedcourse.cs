using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Linkedcourse : IModel 
	{

		public int enddate {get;set;}
		public string fullname {get;set;}
		public string fullnamedisplay {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public string shortname {get;set;}
		public int startdate {get;set;}
		public string summary {get;set;}
		public int summaryformat {get;set;}
		public string viewurl {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enddate",prefix),enddate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullnamedisplay",prefix),fullnamedisplay));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("startdate",prefix),startdate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summary",prefix),summary));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summaryformat",prefix),summaryformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("viewurl",prefix),viewurl));
			return keyValuePairs;
		}

	}
}
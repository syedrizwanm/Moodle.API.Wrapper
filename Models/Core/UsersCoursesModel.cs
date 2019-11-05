using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UsersCoursesModel : IModel 
	{
		public int category {get;set;}
		public int enablecompletion {get;set;}
		public int enddate {get;set;}
		public int enrolledusercount {get;set;}
		public string format {get;set;}
		public string fullname {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public string lang {get;set;}
		public double progress {get;set;}
		public string shortname {get;set;}
		public int showgrades {get;set;}
		public int startdate {get;set;}
		public string summary {get;set;}
		public int summaryformat {get;set;}
		public int visible {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("category",prefix),category.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enablecompletion",prefix),enablecompletion.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enddate",prefix),enddate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enrolledusercount",prefix),enrolledusercount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("format",prefix),format));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lang",prefix),lang));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("progress",prefix),progress.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showgrades",prefix),showgrades.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("startdate",prefix),startdate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summary",prefix),summary));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summaryformat",prefix),summaryformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
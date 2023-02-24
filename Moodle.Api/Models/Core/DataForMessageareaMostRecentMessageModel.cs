using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DataForMessageareaMostRecentMessageModel : IModel 
	{
		public string blocktime {get;set;}
		public int displayblocktime {get;set;}
		public int id {get;set;}
		public int isread {get;set;}
		public string position {get;set;}
		public string text {get;set;}
		public int timecreated {get;set;}
		public string timesent {get;set;}
		public int useridfrom {get;set;}
		public int useridto {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("blocktime",prefix),blocktime));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayblocktime",prefix),displayblocktime.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isread",prefix),isread.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("position",prefix),position));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timesent",prefix),timesent));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridfrom",prefix),useridfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridto",prefix),useridto.ToString()));
			return keyValuePairs;
		}

	}
}
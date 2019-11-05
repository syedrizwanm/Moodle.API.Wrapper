using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Comment : IModel 
	{

		public string avatar {get;set;}
		public string content {get;set;}
		public int delete {get;set;}
		public int format {get;set;}
		public string fullname {get;set;}
		public int id {get;set;}
		public string profileurl {get;set;}
		public string strftimeformat {get;set;}
		public string time {get;set;}
		public int timecreated {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("avatar",prefix),avatar));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content",prefix),content));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("delete",prefix),delete.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("format",prefix),format.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileurl",prefix),profileurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("strftimeformat",prefix),strftimeformat));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("time",prefix),time));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Message : IModel 
	{

		public string contexturl {get;set;}
		public string contexturlname {get;set;}
		public string fullmessage {get;set;}
		public int fullmessageformat {get;set;}
		public string fullmessagehtml {get;set;}
		public int id {get;set;}
		public int notification {get;set;}
		public string smallmessage {get;set;}
		public string subject {get;set;}
		public string text {get;set;}
		public int timecreated {get;set;}
		public int timeread {get;set;}
		public string userfromfullname {get;set;}
		public int useridfrom {get;set;}
		public int useridto {get;set;}
		public string usertofullname {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contexturl",prefix),contexturl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contexturlname",prefix),contexturlname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullmessage",prefix),fullmessage));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullmessageformat",prefix),fullmessageformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullmessagehtml",prefix),fullmessagehtml));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("notification",prefix),notification.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("smallmessage",prefix),smallmessage));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("subject",prefix),subject));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeread",prefix),timeread.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userfromfullname",prefix),userfromfullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridfrom",prefix),useridfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridto",prefix),useridto.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usertofullname",prefix),usertofullname));
			return keyValuePairs;
		}

	}
}
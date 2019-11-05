using System.Collections.Generic;

namespace Moodle.Api.Models.Message
{
	public sealed class Notification : IModel 
	{

		public string component {get;set;}
		public string contexturl {get;set;}
		public string contexturlname {get;set;}
		public int deleted {get;set;}
		public string eventtype {get;set;}
		public string fullmessage {get;set;}
		public int fullmessageformat {get;set;}
		public string fullmessagehtml {get;set;}
		public string iconurl {get;set;}
		public int id {get;set;}
		public int read {get;set;}
		public string shortenedsubject {get;set;}
		public string smallmessage {get;set;}
		public string subject {get;set;}
		public string text {get;set;}
		public int timecreated {get;set;}
		public string timecreatedpretty {get;set;}
		public int timeread {get;set;}
		public int useridfrom {get;set;}
		public int useridto {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contexturl",prefix),contexturl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contexturlname",prefix),contexturlname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("deleted",prefix),deleted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("eventtype",prefix),eventtype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullmessage",prefix),fullmessage));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullmessageformat",prefix),fullmessageformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullmessagehtml",prefix),fullmessagehtml));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iconurl",prefix),iconurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("read",prefix),read.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortenedsubject",prefix),shortenedsubject));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("smallmessage",prefix),smallmessage));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("subject",prefix),subject));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreatedpretty",prefix),timecreatedpretty));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeread",prefix),timeread.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridfrom",prefix),useridfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridto",prefix),useridto.ToString()));
			return keyValuePairs;
		}

	}
}
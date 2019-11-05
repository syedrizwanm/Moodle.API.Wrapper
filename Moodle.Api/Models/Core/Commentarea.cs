using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Commentarea : IModel 
	{

		public int autostart {get;set;}
		public int canpost {get;set;}
		public int canpostorhascomments {get;set;}
		public int canview {get;set;}
		public string cid {get;set;}
		public string collapsediconkey {get;set;}
		public string commentarea {get;set;}
		public string component {get;set;}
		public int contextid {get;set;}
		public int count {get;set;}
		public int courseid {get;set;}
		public int displaycancel {get;set;}
		public int displaytotalcount {get;set;}
		public int fullwidth {get;set;}
		public int itemid {get;set;}
		public string linktext {get;set;}
		public int notoggle {get;set;}
		public string template {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("autostart",prefix),autostart.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canpost",prefix),canpost.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canpostorhascomments",prefix),canpostorhascomments.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canview",prefix),canview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cid",prefix),cid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("collapsediconkey",prefix),collapsediconkey));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("commentarea",prefix),commentarea));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("count",prefix),count.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displaycancel",prefix),displaycancel.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displaytotalcount",prefix),displaytotalcount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullwidth",prefix),fullwidth.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("linktext",prefix),linktext));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("notoggle",prefix),notoggle.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("template",prefix),template));
			return keyValuePairs;
		}

	}
}
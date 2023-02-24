using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Badge : IModel 
	{

		public int attachment {get;set;}
		public string badgeurl {get;set;}
		public int courseid {get;set;}
		public int dateexpire {get;set;}
		public int dateissued {get;set;}
		public string description {get;set;}
		public int expiredate {get;set;}
		public int expireperiod {get;set;}
		public int id {get;set;}
		public int issuedid {get;set;}
		public string issuercontact {get;set;}
		public string issuername {get;set;}
		public string issuerurl {get;set;}
		public string message {get;set;}
		public string messagesubject {get;set;}
		public string name {get;set;}
		public int status {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public int type {get;set;}
		public string uniquehash {get;set;}
		public int usercreated {get;set;}
		public int usermodified {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attachment",prefix),attachment.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("badgeurl",prefix),badgeurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dateexpire",prefix),dateexpire.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dateissued",prefix),dateissued.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("expiredate",prefix),expiredate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("expireperiod",prefix),expireperiod.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("issuedid",prefix),issuedid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("issuercontact",prefix),issuercontact));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("issuername",prefix),issuername));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("issuerurl",prefix),issuerurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("message",prefix),message));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("messagesubject",prefix),messagesubject));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("uniquehash",prefix),uniquehash));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usercreated",prefix),usercreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
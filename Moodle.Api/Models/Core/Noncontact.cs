using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Noncontact : IModel 
	{

		public string fullname {get;set;}
		public int isblocked {get;set;}
		public int ismessaging {get;set;}
		public int isonline {get;set;}
		public int isread {get;set;}
		public string lastmessage {get;set;}
		public int messageid {get;set;}
		public string profileimageurl {get;set;}
		public string profileimageurlsmall {get;set;}
		public int sentfromcurrentuser {get;set;}
		public int showonlinestatus {get;set;}
		public int unreadcount {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isblocked",prefix),isblocked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ismessaging",prefix),ismessaging.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isonline",prefix),isonline.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isread",prefix),isread.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastmessage",prefix),lastmessage));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("messageid",prefix),messageid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurl",prefix),profileimageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurlsmall",prefix),profileimageurlsmall));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sentfromcurrentuser",prefix),sentfromcurrentuser.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showonlinestatus",prefix),showonlinestatus.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("unreadcount",prefix),unreadcount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Actionuser : IModel 
	{

		public string department {get;set;}
		public string email {get;set;}
		public string fullname {get;set;}
		public int id {get;set;}
		public string identity {get;set;}
		public string idnumber {get;set;}
		public string institution {get;set;}
		public string phone1 {get;set;}
		public string phone2 {get;set;}
		public string profileimageurl {get;set;}
		public string profileimageurlsmall {get;set;}
		public string profileurl {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("department",prefix),department));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("email",prefix),email));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("identity",prefix),identity));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("institution",prefix),institution));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("phone1",prefix),phone1));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("phone2",prefix),phone2));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurl",prefix),profileimageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurlsmall",prefix),profileimageurlsmall));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileurl",prefix),profileurl));
			return keyValuePairs;
		}

	}
}
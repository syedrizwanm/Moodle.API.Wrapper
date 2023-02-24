using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DataForMessageareaProfileModel : IModel 
	{
		public string city {get;set;}
		public string country {get;set;}
		public string email {get;set;}
		public string fullname {get;set;}
		public int isblocked {get;set;}
		public int iscontact {get;set;}
		public int isonline {get;set;}
		public string profileimageurl {get;set;}
		public string profileimageurlsmall {get;set;}
		public int showonlinestatus {get;set;}
		public int userid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("city",prefix),city));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("country",prefix),country));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("email",prefix),email));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isblocked",prefix),isblocked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iscontact",prefix),iscontact.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isonline",prefix),isonline.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurl",prefix),profileimageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurlsmall",prefix),profileimageurlsmall));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showonlinestatus",prefix),showonlinestatus.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
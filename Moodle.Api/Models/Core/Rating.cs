using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Rating : IModel 
	{

		public int id {get;set;}
		public string rating {get;set;}
		public int timemodified {get;set;}
		public string userfullname {get;set;}
		public int userid {get;set;}
		public string userpictureurl {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rating",prefix),rating));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userfullname",prefix),userfullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userpictureurl",prefix),userpictureurl));
			return keyValuePairs;
		}

	}
}
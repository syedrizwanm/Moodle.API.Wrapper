using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SearchContactsModel : IModel 
	{
		public string fullname {get;set;}
		public int id {get;set;}
		public string profileimageurl {get;set;}
		public string profileimageurlsmall {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurl",prefix),profileimageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurlsmall",prefix),profileimageurlsmall));
			return keyValuePairs;
		}

	}
}
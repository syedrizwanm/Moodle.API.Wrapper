using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class SearchUsersInputModel : IModel 
	{
		public string capability {get;set;}
		public int limitfrom {get;set;}
		public string limitnum {get;set;}
		public string query {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("capability",prefix),capability));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitfrom",prefix),limitfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitnum",prefix),limitnum));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("query",prefix),query));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SearchContactsInputModel : IModel 
	{
		public int onlymycourses {get;set;}
		public string searchtext {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("onlymycourses",prefix),onlymycourses.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("searchtext",prefix),searchtext));
			return keyValuePairs;
		}

	}
}
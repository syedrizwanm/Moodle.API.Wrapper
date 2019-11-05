using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SearchCoursesInputModel : IModel 
	{
		public string criterianame {get;set;}
		public string criteriavalue {get;set;}
		public int limittoenrolled {get;set;}
		public int page {get;set;}
		public int perpage {get;set;}
		public List<string> requiredcapabilities {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("criterianame",prefix),criterianame));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("criteriavalue",prefix),criteriavalue));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limittoenrolled",prefix),limittoenrolled.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("page",prefix),page.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("perpage",prefix),perpage.ToString()));

			for(var requiredcapabilitiesIndex = 0; requiredcapabilitiesIndex<requiredcapabilities.Count;requiredcapabilitiesIndex++) 
			{
				var requiredcapabilitiesItem = requiredcapabilities[requiredcapabilitiesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("requiredcapabilities[" + requiredcapabilitiesIndex + "]",prefix), requiredcapabilitiesItem));
			}

			return keyValuePairs;
		}

	}
}
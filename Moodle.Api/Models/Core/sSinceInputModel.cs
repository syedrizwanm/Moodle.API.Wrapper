using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class sSinceInputModel : IModel 
	{
		public int courseid {get;set;}
		public List<string> filter {get;set;}
		public int since {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));

			for(var filterIndex = 0; filterIndex<filter.Count;filterIndex++) 
			{
				var filterItem = filter[filterIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filter[" + filterIndex + "]",prefix), filterItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("since",prefix),since.ToString()));
			return keyValuePairs;
		}

	}
}
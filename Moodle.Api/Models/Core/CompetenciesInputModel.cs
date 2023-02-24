using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CompetenciesInputModel : IModel 
	{
		public List<FilterInputModel> filters {get;set;}
		public int limit {get;set;}
		public string order {get;set;}
		public int skip {get;set;}
		public string sort {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var filtersIndex = 0; filtersIndex<filters.Count;filtersIndex++) 
			{
				var filtersItem = filters[filtersIndex];
				var filtersItems = filtersItem.ToKeyValuePairs("filters[" + filtersIndex + "]");
				keyValuePairs.AddRange(filtersItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limit",prefix),limit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("order",prefix),order));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("skip",prefix),skip.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sort",prefix),sort));
			return keyValuePairs;
		}

	}
}
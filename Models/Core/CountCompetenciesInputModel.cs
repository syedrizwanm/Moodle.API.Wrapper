using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CountCompetenciesInputModel : IModel 
	{
		public List<FilterInputModel> filters {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var filtersIndex = 0; filtersIndex<filters.Count;filtersIndex++) 
			{
				var filtersItem = filters[filtersIndex];
				var filtersItems = filtersItem.ToKeyValuePairs("filters[" + filtersIndex + "]");
				keyValuePairs.AddRange(filtersItems);
			}

			return keyValuePairs;
		}

	}
}
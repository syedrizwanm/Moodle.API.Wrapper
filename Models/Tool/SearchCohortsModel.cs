using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class SearchCohortsModel : IModel 
	{
		public List<Cohort> cohorts {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var cohortsIndex = 0; cohortsIndex<cohorts.Count;cohortsIndex++) 
			{
				var cohortsItem = cohorts[cohortsIndex];
				var cohortsItems = cohortsItem.ToKeyValuePairs("cohorts[" + cohortsIndex + "]");
				keyValuePairs.AddRange(cohortsItems);
			}

			return keyValuePairs;
		}

	}
}
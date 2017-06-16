using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class Rubric : IModel 
	{

		public List<Criteria> criteria {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var criteriaIndex = 0; criteriaIndex<criteria.Count;criteriaIndex++) 
			{
				var criteriaItem = criteria[criteriaIndex];
				var criteriaItems = criteriaItem.ToKeyValuePairs("criteria[" + criteriaIndex + "]");
				keyValuePairs.AddRange(criteriaItems);
			}

			return keyValuePairs;
		}

	}
}
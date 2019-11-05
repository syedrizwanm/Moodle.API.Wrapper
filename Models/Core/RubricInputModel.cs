using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class RubricInputModel : IModel 
	{

		public List<Rubric_CriteriaInputModel> rubric_criteria {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var rubric_criteriaIndex = 0; rubric_criteriaIndex<rubric_criteria.Count;rubric_criteriaIndex++) 
			{
				var rubric_criteriaItem = rubric_criteria[rubric_criteriaIndex];
				var rubric_criteriaItems = rubric_criteriaItem.ToKeyValuePairs("rubric_criteria[" + rubric_criteriaIndex + "]");
				keyValuePairs.AddRange(rubric_criteriaItems);
			}

			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Tool
{
	public sealed class DataForUserCompetencySummaryInPlanModel : IModel 
	{
		public Plan plan {get;set;}
		public Usercompetencysummary usercompetencysummary {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var planItems = plan.ToKeyValuePairs("plan");
			keyValuePairs.AddRange(planItems);
			var usercompetencysummaryItems = usercompetencysummary.ToKeyValuePairs("usercompetencysummary");
			keyValuePairs.AddRange(usercompetencysummaryItems);
			return keyValuePairs;
		}

	}
}
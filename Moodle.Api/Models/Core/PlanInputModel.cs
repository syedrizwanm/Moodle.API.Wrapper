using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class PlanInputModel : IModel 
	{
		public PlanInputModelClass plan {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var planItems = plan.ToKeyValuePairs("plan");
			keyValuePairs.AddRange(planItems);
			return keyValuePairs;
		}

	}
}
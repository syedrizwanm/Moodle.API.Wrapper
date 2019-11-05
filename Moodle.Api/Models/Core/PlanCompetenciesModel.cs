using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class PlanCompetenciesModel : IModel 
	{
		public Competency competency {get;set;}
		public Usercompetency usercompetency {get;set;}
		public Usercompetencyplan usercompetencyplan {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var competencyItems = competency.ToKeyValuePairs("competency");
			keyValuePairs.AddRange(competencyItems);
			var usercompetencyItems = usercompetency.ToKeyValuePairs("usercompetency");
			keyValuePairs.AddRange(usercompetencyItems);
			var usercompetencyplanItems = usercompetencyplan.ToKeyValuePairs("usercompetencyplan");
			keyValuePairs.AddRange(usercompetencyplanItems);
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CompetencyFrameworkInputModel : IModel 
	{
		public CompetencyframeworkInputModelClass competencyframework {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var competencyframeworkItems = competencyframework.ToKeyValuePairs("competencyframework");
			keyValuePairs.AddRange(competencyframeworkItems);
			return keyValuePairs;
		}

	}
}
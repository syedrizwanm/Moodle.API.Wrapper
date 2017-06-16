using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class CompetencyInputModel : IModel 
	{
		public CompetencyInputModelClass competency {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var competencyItems = competency.ToKeyValuePairs("competency");
			keyValuePairs.AddRange(competencyItems);
			return keyValuePairs;
		}

	}
}
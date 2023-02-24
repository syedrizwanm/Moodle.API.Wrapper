using System.Collections.Generic;

namespace Moodle.Api.Models.Report
{
	public sealed class Usercompetencie : IModel 
	{

		public Competency competency {get;set;}
		public Usercompetencycourse usercompetencycourse {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var competencyItems = competency.ToKeyValuePairs("competency");
			keyValuePairs.AddRange(competencyItems);
			var usercompetencycourseItems = usercompetencycourse.ToKeyValuePairs("usercompetencycourse");
			keyValuePairs.AddRange(usercompetencycourseItems);
			return keyValuePairs;
		}

	}
}
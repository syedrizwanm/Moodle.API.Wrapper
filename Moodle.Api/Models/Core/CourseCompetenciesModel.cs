using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CourseCompetenciesModel : IModel 
	{
		public Competency competency {get;set;}
		public Coursecompetency coursecompetency {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var competencyItems = competency.ToKeyValuePairs("competency");
			keyValuePairs.AddRange(competencyItems);
			var coursecompetencyItems = coursecompetency.ToKeyValuePairs("coursecompetency");
			keyValuePairs.AddRange(coursecompetencyItems);
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Usercompetencie : IModel 
	{

		public Competency competency {get;set;}
		public Usercompetency usercompetency {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var competencyItems = competency.ToKeyValuePairs("competency");
			keyValuePairs.AddRange(competencyItems);
			var usercompetencyItems = usercompetency.ToKeyValuePairs("usercompetency");
			keyValuePairs.AddRange(usercompetencyItems);
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SetCourseCompetencyRuleoutcomeInputModel : IModel 
	{
		public int coursecompetencyid {get;set;}
		public int ruleoutcome {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("coursecompetencyid",prefix),coursecompetencyid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ruleoutcome",prefix),ruleoutcome.ToString()));
			return keyValuePairs;
		}

	}
}
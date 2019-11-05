using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Usercompetencysummary : IModel 
	{

		public int cangrade {get;set;}
		public Commentarea commentarea {get;set;}
		public Competency competency {get;set;}
		public List<Evidence> evidence {get;set;}
		public int showrelatedcompetencies {get;set;}
		public User user {get;set;}
		public Usercompetency usercompetency {get;set;}
		public Usercompetencycourse usercompetencycourse {get;set;}
		public Usercompetencyplan usercompetencyplan {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cangrade",prefix),cangrade.ToString()));
			var commentareaItems = commentarea.ToKeyValuePairs("commentarea");
			keyValuePairs.AddRange(commentareaItems);
			var competencyItems = competency.ToKeyValuePairs("competency");
			keyValuePairs.AddRange(competencyItems);

			for(var evidenceIndex = 0; evidenceIndex<evidence.Count;evidenceIndex++) 
			{
				var evidenceItem = evidence[evidenceIndex];
				var evidenceItems = evidenceItem.ToKeyValuePairs("evidence[" + evidenceIndex + "]");
				keyValuePairs.AddRange(evidenceItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showrelatedcompetencies",prefix),showrelatedcompetencies.ToString()));
			var userItems = user.ToKeyValuePairs("user");
			keyValuePairs.AddRange(userItems);
			var usercompetencyItems = usercompetency.ToKeyValuePairs("usercompetency");
			keyValuePairs.AddRange(usercompetencyItems);
			var usercompetencycourseItems = usercompetencycourse.ToKeyValuePairs("usercompetencycourse");
			keyValuePairs.AddRange(usercompetencycourseItems);
			var usercompetencyplanItems = usercompetencyplan.ToKeyValuePairs("usercompetencyplan");
			keyValuePairs.AddRange(usercompetencyplanItems);
			return keyValuePairs;
		}

	}
}
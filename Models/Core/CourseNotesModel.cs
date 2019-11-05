using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CourseNotesModel : IModel 
	{
		public List<Coursenote> coursenotes {get;set;}
		public List<Personalnote> personalnotes {get;set;}
		public List<Sitenote> sitenotes {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var coursenotesIndex = 0; coursenotesIndex<coursenotes.Count;coursenotesIndex++) 
			{
				var coursenotesItem = coursenotes[coursenotesIndex];
				var coursenotesItems = coursenotesItem.ToKeyValuePairs("coursenotes[" + coursenotesIndex + "]");
				keyValuePairs.AddRange(coursenotesItems);
			}


			for(var personalnotesIndex = 0; personalnotesIndex<personalnotes.Count;personalnotesIndex++) 
			{
				var personalnotesItem = personalnotes[personalnotesIndex];
				var personalnotesItems = personalnotesItem.ToKeyValuePairs("personalnotes[" + personalnotesIndex + "]");
				keyValuePairs.AddRange(personalnotesItems);
			}


			for(var sitenotesIndex = 0; sitenotesIndex<sitenotes.Count;sitenotesIndex++) 
			{
				var sitenotesItem = sitenotes[sitenotesIndex];
				var sitenotesItems = sitenotesItem.ToKeyValuePairs("sitenotes[" + sitenotesIndex + "]");
				keyValuePairs.AddRange(sitenotesItems);
			}


			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}
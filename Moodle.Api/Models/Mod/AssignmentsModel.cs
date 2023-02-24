using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AssignmentsModel : IModel 
	{
		public List<Course> courses {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var coursesIndex = 0; coursesIndex<courses.Count;coursesIndex++) 
			{
				var coursesItem = courses[coursesIndex];
				var coursesItems = coursesItem.ToKeyValuePairs("courses[" + coursesIndex + "]");
				keyValuePairs.AddRange(coursesItems);
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
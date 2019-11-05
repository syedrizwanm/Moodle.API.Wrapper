using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubmissionsModel : IModel 
	{
		public List<Assignment> assignments {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var assignmentsIndex = 0; assignmentsIndex<assignments.Count;assignmentsIndex++) 
			{
				var assignmentsItem = assignments[assignmentsIndex];
				var assignmentsItems = assignmentsItem.ToKeyValuePairs("assignments[" + assignmentsIndex + "]");
				keyValuePairs.AddRange(assignmentsItems);
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
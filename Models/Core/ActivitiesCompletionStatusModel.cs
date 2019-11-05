using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ActivitiesCompletionStatusModel : IModel 
	{
		public List<Statuse> statuses {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var statusesIndex = 0; statusesIndex<statuses.Count;statusesIndex++) 
			{
				var statusesItem = statuses[statusesIndex];
				var statusesItems = statusesItem.ToKeyValuePairs("statuses[" + statusesIndex + "]");
				keyValuePairs.AddRange(statusesItems);
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
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class CurrentCompletedTmpModel : IModel 
	{
		public Feedback feedback {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var feedbackItems = feedback.ToKeyValuePairs("feedback");
			keyValuePairs.AddRange(feedbackItems);

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
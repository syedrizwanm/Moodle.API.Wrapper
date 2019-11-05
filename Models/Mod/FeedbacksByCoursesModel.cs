using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class FeedbacksByCoursesModel : IModel 
	{
		public List<Feedback> feedbacks {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var feedbacksIndex = 0; feedbacksIndex<feedbacks.Count;feedbacksIndex++) 
			{
				var feedbacksItem = feedbacks[feedbacksIndex];
				var feedbacksItems = feedbacksItem.ToKeyValuePairs("feedbacks[" + feedbacksIndex + "]");
				keyValuePairs.AddRange(feedbacksItems);
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
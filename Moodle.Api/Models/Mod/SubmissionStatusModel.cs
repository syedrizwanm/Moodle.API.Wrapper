using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubmissionStatusModel : IModel 
	{
		public Feedback feedback {get;set;}
		public Gradingsummary gradingsummary {get;set;}
		public Lastattempt lastattempt {get;set;}
		public List<Previousattempt> previousattempts {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var feedbackItems = feedback.ToKeyValuePairs("feedback");
			keyValuePairs.AddRange(feedbackItems);
			var gradingsummaryItems = gradingsummary.ToKeyValuePairs("gradingsummary");
			keyValuePairs.AddRange(gradingsummaryItems);
			var lastattemptItems = lastattempt.ToKeyValuePairs("lastattempt");
			keyValuePairs.AddRange(lastattemptItems);

			for(var previousattemptsIndex = 0; previousattemptsIndex<previousattempts.Count;previousattemptsIndex++) 
			{
				var previousattemptsItem = previousattempts[previousattemptsIndex];
				var previousattemptsItems = previousattemptsItem.ToKeyValuePairs("previousattempts[" + previousattemptsIndex + "]");
				keyValuePairs.AddRange(previousattemptsItems);
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
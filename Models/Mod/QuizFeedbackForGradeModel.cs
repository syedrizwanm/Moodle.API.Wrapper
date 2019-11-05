using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class QuizFeedbackForGradeModel : IModel 
	{
		public List<Feedbackinlinefile> feedbackinlinefiles {get;set;}
		public string feedbacktext {get;set;}
		public int feedbacktextformat {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var feedbackinlinefilesIndex = 0; feedbackinlinefilesIndex<feedbackinlinefiles.Count;feedbackinlinefilesIndex++) 
			{
				var feedbackinlinefilesItem = feedbackinlinefiles[feedbackinlinefilesIndex];
				var feedbackinlinefilesItems = feedbackinlinefilesItem.ToKeyValuePairs("feedbackinlinefiles[" + feedbackinlinefilesIndex + "]");
				keyValuePairs.AddRange(feedbackinlinefilesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedbacktext",prefix),feedbacktext));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedbacktextformat",prefix),feedbacktextformat.ToString()));

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
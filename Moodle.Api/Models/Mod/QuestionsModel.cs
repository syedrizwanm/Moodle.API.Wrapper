using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class QuestionsModel : IModel 
	{
		public List<Question> questions {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var questionsIndex = 0; questionsIndex<questions.Count;questionsIndex++) 
			{
				var questionsItem = questions[questionsIndex];
				var questionsItems = questionsItem.ToKeyValuePairs("questions[" + questionsIndex + "]");
				keyValuePairs.AddRange(questionsItems);
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
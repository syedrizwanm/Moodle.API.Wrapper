using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubmitChoiceResponseModel : IModel 
	{
		public List<Answer> answers {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var answersIndex = 0; answersIndex<answers.Count;answersIndex++) 
			{
				var answersItem = answers[answersIndex];
				var answersItems = answersItem.ToKeyValuePairs("answers[" + answersIndex + "]");
				keyValuePairs.AddRange(answersItems);
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
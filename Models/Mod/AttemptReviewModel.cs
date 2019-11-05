using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AttemptReviewModel : IModel 
	{
		public List<Additionaldata> additionaldata {get;set;}
		public Attempt attempt {get;set;}
		public string grade {get;set;}
		public List<Question> questions {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var additionaldataIndex = 0; additionaldataIndex<additionaldata.Count;additionaldataIndex++) 
			{
				var additionaldataItem = additionaldata[additionaldataIndex];
				var additionaldataItems = additionaldataItem.ToKeyValuePairs("additionaldata[" + additionaldataIndex + "]");
				keyValuePairs.AddRange(additionaldataItems);
			}

			var attemptItems = attempt.ToKeyValuePairs("attempt");
			keyValuePairs.AddRange(attemptItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade));

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
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AttemptDataModel : IModel 
	{
		public Attempt attempt {get;set;}
		public List<string> messages {get;set;}
		public int nextpage {get;set;}
		public List<Question> questions {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var attemptItems = attempt.ToKeyValuePairs("attempt");
			keyValuePairs.AddRange(attemptItems);

			for(var messagesIndex = 0; messagesIndex<messages.Count;messagesIndex++) 
			{
				var messagesItem = messages[messagesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("messages[" + messagesIndex + "]",prefix), messagesItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("nextpage",prefix),nextpage.ToString()));

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
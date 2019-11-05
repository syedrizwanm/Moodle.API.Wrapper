using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class QuestionsAttemptsModel : IModel 
	{
		public List<Attempt> attempts {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var attemptsIndex = 0; attemptsIndex<attempts.Count;attemptsIndex++) 
			{
				var attemptsItem = attempts[attemptsIndex];
				var attemptsItems = attemptsItem.ToKeyValuePairs("attempts[" + attemptsIndex + "]");
				keyValuePairs.AddRange(attemptsItems);
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
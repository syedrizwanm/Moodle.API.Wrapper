using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class UserAttemptModel : IModel 
	{
		public List<Answerpage> answerpages {get;set;}
		public Userstat userstats {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var answerpagesIndex = 0; answerpagesIndex<answerpages.Count;answerpagesIndex++) 
			{
				var answerpagesItem = answerpages[answerpagesIndex];
				var answerpagesItems = answerpagesItem.ToKeyValuePairs("answerpages[" + answerpagesIndex + "]");
				keyValuePairs.AddRange(answerpagesItems);
			}

			var userstatsItems = userstats.ToKeyValuePairs("userstats");
			keyValuePairs.AddRange(userstatsItems);

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
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ResponsesAnalysisModel : IModel 
	{
		public List<Anonattempt> anonattempts {get;set;}
		public List<Attempt> attempts {get;set;}
		public int totalanonattempts {get;set;}
		public int totalattempts {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var anonattemptsIndex = 0; anonattemptsIndex<anonattempts.Count;anonattemptsIndex++) 
			{
				var anonattemptsItem = anonattempts[anonattemptsIndex];
				var anonattemptsItems = anonattemptsItem.ToKeyValuePairs("anonattempts[" + anonattemptsIndex + "]");
				keyValuePairs.AddRange(anonattemptsItems);
			}


			for(var attemptsIndex = 0; attemptsIndex<attempts.Count;attemptsIndex++) 
			{
				var attemptsItem = attempts[attemptsIndex];
				var attemptsItems = attemptsItem.ToKeyValuePairs("attempts[" + attemptsIndex + "]");
				keyValuePairs.AddRange(attemptsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("totalanonattempts",prefix),totalanonattempts.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("totalattempts",prefix),totalattempts.ToString()));

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
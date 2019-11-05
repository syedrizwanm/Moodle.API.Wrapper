using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class FinishedResponsesModel : IModel 
	{
		public List<Response> responses {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var responsesIndex = 0; responsesIndex<responses.Count;responsesIndex++) 
			{
				var responsesItem = responses[responsesIndex];
				var responsesItems = responsesItem.ToKeyValuePairs("responses[" + responsesIndex + "]");
				keyValuePairs.AddRange(responsesItems);
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
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class DeleteChoiceResponsesInputModel : IModel 
	{
		public int choiceid {get;set;}
		public List<int> responses {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("choiceid",prefix),choiceid.ToString()));

			for(var responsesIndex = 0; responsesIndex<responses.Count;responsesIndex++) 
			{
				var responsesItem = responses[responsesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("responses[" + responsesIndex + "]",prefix), responsesItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}
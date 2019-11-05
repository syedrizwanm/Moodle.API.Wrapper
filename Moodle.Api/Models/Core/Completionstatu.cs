using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Completionstatu : IModel 
	{

		public int aggregation {get;set;}
		public int completed {get;set;}
		public List<Completion> completions {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("aggregation",prefix),aggregation.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completed",prefix),completed.ToString()));

			for(var completionsIndex = 0; completionsIndex<completions.Count;completionsIndex++) 
			{
				var completionsItem = completions[completionsIndex];
				var completionsItems = completionsItem.ToKeyValuePairs("completions[" + completionsIndex + "]");
				keyValuePairs.AddRange(completionsItems);
			}

			return keyValuePairs;
		}

	}
}
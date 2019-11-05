using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class GradesModel : IModel 
	{
		public List<Item> items {get;set;}
		public List<Outcome> outcomes {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var itemsIndex = 0; itemsIndex<items.Count;itemsIndex++) 
			{
				var itemsItem = items[itemsIndex];
				var itemsItems = itemsItem.ToKeyValuePairs("items[" + itemsIndex + "]");
				keyValuePairs.AddRange(itemsItems);
			}


			for(var outcomesIndex = 0; outcomesIndex<outcomes.Count;outcomesIndex++) 
			{
				var outcomesItem = outcomes[outcomesIndex];
				var outcomesItems = outcomesItem.ToKeyValuePairs("outcomes[" + outcomesIndex + "]");
				keyValuePairs.AddRange(outcomesItems);
			}

			return keyValuePairs;
		}

	}
}
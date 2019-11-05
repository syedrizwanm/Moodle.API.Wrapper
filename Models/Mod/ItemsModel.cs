using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ItemsModel : IModel 
	{
		public List<Item> items {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var itemsIndex = 0; itemsIndex<items.Count;itemsIndex++) 
			{
				var itemsItem = items[itemsIndex];
				var itemsItems = itemsItem.ToKeyValuePairs("items[" + itemsIndex + "]");
				keyValuePairs.AddRange(itemsItems);
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
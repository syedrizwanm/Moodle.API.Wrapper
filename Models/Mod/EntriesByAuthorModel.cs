using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class EntriesByAuthorModel : IModel 
	{
		public int count {get;set;}
		public List<Entrie> entries {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("count",prefix),count.ToString()));

			for(var entriesIndex = 0; entriesIndex<entries.Count;entriesIndex++) 
			{
				var entriesItem = entries[entriesIndex];
				var entriesItems = entriesItem.ToKeyValuePairs("entries[" + entriesIndex + "]");
				keyValuePairs.AddRange(entriesItems);
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
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SearchEntriesModel : IModel 
	{
		public List<Entrie> entries {get;set;}
		public string listviewcontents {get;set;}
		public int totalcount {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var entriesIndex = 0; entriesIndex<entries.Count;entriesIndex++) 
			{
				var entriesItem = entries[entriesIndex];
				var entriesItems = entriesItem.ToKeyValuePairs("entries[" + entriesIndex + "]");
				keyValuePairs.AddRange(entriesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("listviewcontents",prefix),listviewcontents));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("totalcount",prefix),totalcount.ToString()));

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
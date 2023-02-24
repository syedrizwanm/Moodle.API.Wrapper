using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SetUserPreferencesModel : IModel 
	{
		public List<Saved> saved {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var savedIndex = 0; savedIndex<saved.Count;savedIndex++) 
			{
				var savedItem = saved[savedIndex];
				var savedItems = savedItem.ToKeyValuePairs("saved[" + savedIndex + "]");
				keyValuePairs.AddRange(savedItems);
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
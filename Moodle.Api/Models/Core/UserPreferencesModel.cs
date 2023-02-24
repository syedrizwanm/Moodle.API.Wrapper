using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserPreferencesModel : IModel 
	{
		public List<Preference> preferences {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var preferencesIndex = 0; preferencesIndex<preferences.Count;preferencesIndex++) 
			{
				var preferencesItem = preferences[preferencesIndex];
				var preferencesItems = preferencesItem.ToKeyValuePairs("preferences[" + preferencesIndex + "]");
				keyValuePairs.AddRange(preferencesItems);
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
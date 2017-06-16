using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class SetUserPreferencesInputModel : IModel 
	{
		public List<PreferenceInputModel> preferences {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var preferencesIndex = 0; preferencesIndex<preferences.Count;preferencesIndex++) 
			{
				var preferencesItem = preferences[preferencesIndex];
				var preferencesItems = preferencesItem.ToKeyValuePairs("preferences[" + preferencesIndex + "]");
				keyValuePairs.AddRange(preferencesItems);
			}

			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class ConfigModel : IModel 
	{
		public List<Setting> settings {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var settingsIndex = 0; settingsIndex<settings.Count;settingsIndex++) 
			{
				var settingsItem = settings[settingsIndex];
				var settingsItems = settingsItem.ToKeyValuePairs("settings[" + settingsIndex + "]");
				keyValuePairs.AddRange(settingsItems);
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
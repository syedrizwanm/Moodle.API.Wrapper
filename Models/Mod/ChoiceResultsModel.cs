using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ChoiceResultsModel : IModel 
	{
		public List<Option> options {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var optionsIndex = 0; optionsIndex<options.Count;optionsIndex++) 
			{
				var optionsItem = options[optionsIndex];
				var optionsItems = optionsItem.ToKeyValuePairs("options[" + optionsIndex + "]");
				keyValuePairs.AddRange(optionsItems);
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
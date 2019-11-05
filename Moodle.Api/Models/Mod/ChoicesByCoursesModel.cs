using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ChoicesByCoursesModel : IModel 
	{
		public List<Choice> choices {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var choicesIndex = 0; choicesIndex<choices.Count;choicesIndex++) 
			{
				var choicesItem = choices[choicesIndex];
				var choicesItems = choicesItem.ToKeyValuePairs("choices[" + choicesIndex + "]");
				keyValuePairs.AddRange(choicesItems);
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
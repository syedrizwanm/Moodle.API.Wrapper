using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ScormsByCoursesModel : IModel 
	{
		public List<Scorm> scorms {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var scormsIndex = 0; scormsIndex<scorms.Count;scormsIndex++) 
			{
				var scormsItem = scorms[scormsIndex];
				var scormsItems = scormsItem.ToKeyValuePairs("scorms[" + scormsIndex + "]");
				keyValuePairs.AddRange(scormsItems);
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
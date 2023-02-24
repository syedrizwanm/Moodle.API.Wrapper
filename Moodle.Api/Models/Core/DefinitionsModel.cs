using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DefinitionsModel : IModel 
	{
		public List<Area> areas {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var areasIndex = 0; areasIndex<areas.Count;areasIndex++) 
			{
				var areasItem = areas[areasIndex];
				var areasItems = areasItem.ToKeyValuePairs("areas[" + areasIndex + "]");
				keyValuePairs.AddRange(areasItems);
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
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ResourcesByCoursesModel : IModel 
	{
		public List<Resource> resources {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var resourcesIndex = 0; resourcesIndex<resources.Count;resourcesIndex++) 
			{
				var resourcesItem = resources[resourcesIndex];
				var resourcesItems = resourcesItem.ToKeyValuePairs("resources[" + resourcesIndex + "]");
				keyValuePairs.AddRange(resourcesItems);
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
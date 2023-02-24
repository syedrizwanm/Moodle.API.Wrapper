using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ChecksModel : IModel 
	{
		public List<Instance> instances {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var instancesIndex = 0; instancesIndex<instances.Count;instancesIndex++) 
			{
				var instancesItem = instances[instancesIndex];
				var instancesItems = instancesItem.ToKeyValuePairs("instances[" + instancesIndex + "]");
				keyValuePairs.AddRange(instancesItems);
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
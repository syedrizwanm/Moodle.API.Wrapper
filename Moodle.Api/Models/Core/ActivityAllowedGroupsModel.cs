using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ActivityAllowedGroupsModel : IModel 
	{
		public List<Group> groups {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var groupsIndex = 0; groupsIndex<groups.Count;groupsIndex++) 
			{
				var groupsItem = groups[groupsIndex];
				var groupsItems = groupsItem.ToKeyValuePairs("groups[" + groupsIndex + "]");
				keyValuePairs.AddRange(groupsItems);
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
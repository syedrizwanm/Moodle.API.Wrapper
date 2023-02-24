using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class GroupsInputModel : IModel 
	{
		public List<GroupInputModel> groups {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var groupsIndex = 0; groupsIndex<groups.Count;groupsIndex++) 
			{
				var groupsItem = groups[groupsIndex];
				var groupsItems = groupsItem.ToKeyValuePairs("groups[" + groupsIndex + "]");
				keyValuePairs.AddRange(groupsItems);
			}

			return keyValuePairs;
		}

	}
}
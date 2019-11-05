using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class GroupingsInputModel : IModel 
	{

		public List<GroupingInputModel> groupings {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var groupingsIndex = 0; groupingsIndex<groupings.Count;groupingsIndex++) 
			{
				var groupingsItem = groupings[groupingsIndex];
				var groupingsItems = groupingsItem.ToKeyValuePairs("groupings[" + groupingsIndex + "]");
				keyValuePairs.AddRange(groupingsItems);
			}

			return keyValuePairs;
		}

	}
}
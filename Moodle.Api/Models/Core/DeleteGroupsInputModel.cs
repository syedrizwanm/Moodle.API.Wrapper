using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DeleteGroupsInputModel : IModel 
	{
		public List<int> groupids {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var groupidsIndex = 0; groupidsIndex<groupids.Count;groupidsIndex++) 
			{
				var groupidsItem = groupids[groupidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupids[" + groupidsIndex + "]",prefix), groupidsItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}
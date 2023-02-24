using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DeleteGroupingsInputModel : IModel 
	{
		public List<int> groupingids {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var groupingidsIndex = 0; groupingidsIndex<groupingids.Count;groupingidsIndex++) 
			{
				var groupingidsItem = groupingids[groupingidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupingids[" + groupingidsIndex + "]",prefix), groupingidsItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}
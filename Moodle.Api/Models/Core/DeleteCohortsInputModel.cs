using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DeleteCohortsInputModel : IModel 
	{
		public List<int> cohortids {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var cohortidsIndex = 0; cohortidsIndex<cohortids.Count;cohortidsIndex++) 
			{
				var cohortidsItem = cohortids[cohortidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cohortids[" + cohortidsIndex + "]",prefix), cohortidsItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ItemRatingsModel : IModel 
	{
		public List<Rating> ratings {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var ratingsIndex = 0; ratingsIndex<ratings.Count;ratingsIndex++) 
			{
				var ratingsItem = ratings[ratingsIndex];
				var ratingsItems = ratingsItem.ToKeyValuePairs("ratings[" + ratingsIndex + "]");
				keyValuePairs.AddRange(ratingsItems);
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
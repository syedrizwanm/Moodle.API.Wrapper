using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserBadgesModel : IModel 
	{
		public List<Badge> badges {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var badgesIndex = 0; badgesIndex<badges.Count;badgesIndex++) 
			{
				var badgesItem = badges[badgesIndex];
				var badgesItems = badgesItem.ToKeyValuePairs("badges[" + badgesIndex + "]");
				keyValuePairs.AddRange(badgesItems);
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
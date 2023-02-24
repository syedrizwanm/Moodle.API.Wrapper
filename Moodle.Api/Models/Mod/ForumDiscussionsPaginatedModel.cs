using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ForumDiscussionsPaginatedModel : IModel 
	{
		public List<Discussion> discussions {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var discussionsIndex = 0; discussionsIndex<discussions.Count;discussionsIndex++) 
			{
				var discussionsItem = discussions[discussionsIndex];
				var discussionsItems = discussionsItem.ToKeyValuePairs("discussions[" + discussionsIndex + "]");
				keyValuePairs.AddRange(discussionsItems);
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
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ForumDiscussionPostsModel : IModel 
	{
		public List<Post> posts {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var postsIndex = 0; postsIndex<posts.Count;postsIndex++) 
			{
				var postsItem = posts[postsIndex];
				var postsItems = postsItem.ToKeyValuePairs("posts[" + postsIndex + "]");
				keyValuePairs.AddRange(postsItems);
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
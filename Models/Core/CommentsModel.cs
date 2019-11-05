using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CommentsModel : IModel 
	{
		public List<Comment> comments {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var commentsIndex = 0; commentsIndex<comments.Count;commentsIndex++) 
			{
				var commentsItem = comments[commentsIndex];
				var commentsItems = commentsItem.ToKeyValuePairs("comments[" + commentsIndex + "]");
				keyValuePairs.AddRange(commentsItems);
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
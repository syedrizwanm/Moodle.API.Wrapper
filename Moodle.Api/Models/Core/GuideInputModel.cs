using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class GuideInputModel : IModel 
	{

		public List<Guide_CommentsInputModel> guide_comments {get;set;}
		public List<Guide_CriteriaInputModel> guide_criteria {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var guide_commentsIndex = 0; guide_commentsIndex<guide_comments.Count;guide_commentsIndex++) 
			{
				var guide_commentsItem = guide_comments[guide_commentsIndex];
				var guide_commentsItems = guide_commentsItem.ToKeyValuePairs("guide_comments[" + guide_commentsIndex + "]");
				keyValuePairs.AddRange(guide_commentsItems);
			}


			for(var guide_criteriaIndex = 0; guide_criteriaIndex<guide_criteria.Count;guide_criteriaIndex++) 
			{
				var guide_criteriaItem = guide_criteria[guide_criteriaIndex];
				var guide_criteriaItems = guide_criteriaItem.ToKeyValuePairs("guide_criteria[" + guide_criteriaIndex + "]");
				keyValuePairs.AddRange(guide_criteriaItems);
			}

			return keyValuePairs;
		}

	}
}
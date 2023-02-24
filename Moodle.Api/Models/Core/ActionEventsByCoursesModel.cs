using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ActionEventsByCoursesModel : IModel 
	{
		public List<Groupedbycourse> groupedbycourse {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var groupedbycourseIndex = 0; groupedbycourseIndex<groupedbycourse.Count;groupedbycourseIndex++) 
			{
				var groupedbycourseItem = groupedbycourse[groupedbycourseIndex];
				var groupedbycourseItems = groupedbycourseItem.ToKeyValuePairs("groupedbycourse[" + groupedbycourseIndex + "]");
				keyValuePairs.AddRange(groupedbycourseItems);
			}

			return keyValuePairs;
		}

	}
}
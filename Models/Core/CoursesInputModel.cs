using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class CoursesInputModel : IModel 
	{

		public List<CoursInputModel> courses {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var coursesIndex = 0; coursesIndex<courses.Count;coursesIndex++) 
			{
				var coursesItem = courses[coursesIndex];
				var coursesItems = coursesItem.ToKeyValuePairs("courses[" + coursesIndex + "]");
				keyValuePairs.AddRange(coursesItems);
			}

			return keyValuePairs;
		}

	}
}
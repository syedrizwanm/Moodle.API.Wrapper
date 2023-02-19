using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CoursesInputModel : RequestStringGenerator, IModel
	{

		public List<CoursInputModel> courses {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.AddRange(DynamicKeyValuePairsOnlyNonList(prefix));



			for (var coursesIndex = 0; coursesIndex<courses.Count;coursesIndex++) 
			{
				var coursesItem = courses[coursesIndex];
				var coursesItems = coursesItem.ToKeyValuePairs("courses[" + coursesIndex + "]");
				keyValuePairs.AddRange(coursesItems);
			}

			return keyValuePairs;
		}

	}
}
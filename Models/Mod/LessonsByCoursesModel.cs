using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class LessonsByCoursesModel : IModel 
	{
		public List<Lesson> lessons {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var lessonsIndex = 0; lessonsIndex<lessons.Count;lessonsIndex++) 
			{
				var lessonsItem = lessons[lessonsIndex];
				var lessonsItems = lessonsItem.ToKeyValuePairs("lessons[" + lessonsIndex + "]");
				keyValuePairs.AddRange(lessonsItems);
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
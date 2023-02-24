using System.Collections.Generic;

namespace Moodle.Api.Models.Gradereport
{
	public sealed class CourseGradesModel : IModel 
	{
		public List<Grade> grades {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var gradesIndex = 0; gradesIndex<grades.Count;gradesIndex++) 
			{
				var gradesItem = grades[gradesIndex];
				var gradesItems = gradesItem.ToKeyValuePairs("grades[" + gradesIndex + "]");
				keyValuePairs.AddRange(gradesItems);
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
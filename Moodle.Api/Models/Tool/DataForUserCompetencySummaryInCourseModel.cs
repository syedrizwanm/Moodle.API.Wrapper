using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForUserCompetencySummaryInCourseModel : IModel 
	{
		public Course course {get;set;}
		public List<Coursemodule> coursemodules {get;set;}
		public Usercompetencysummary usercompetencysummary {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var courseItems = course.ToKeyValuePairs("course");
			keyValuePairs.AddRange(courseItems);

			for(var coursemodulesIndex = 0; coursemodulesIndex<coursemodules.Count;coursemodulesIndex++) 
			{
				var coursemodulesItem = coursemodules[coursemodulesIndex];
				var coursemodulesItems = coursemodulesItem.ToKeyValuePairs("coursemodules[" + coursemodulesIndex + "]");
				keyValuePairs.AddRange(coursemodulesItems);
			}

			var usercompetencysummaryItems = usercompetencysummary.ToKeyValuePairs("usercompetencysummary");
			keyValuePairs.AddRange(usercompetencysummaryItems);
			return keyValuePairs;
		}

	}
}
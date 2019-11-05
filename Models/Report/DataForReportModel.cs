using System.Collections.Generic;

namespace Moodle.Api.Models.Report
{
	public sealed class DataForReportModel : IModel 
	{
		public Course course {get;set;}
		public int courseid {get;set;}
		public int pushratingstouserplans {get;set;}
		public User user {get;set;}
		public List<Usercompetencie> usercompetencies {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var courseItems = course.ToKeyValuePairs("course");
			keyValuePairs.AddRange(courseItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pushratingstouserplans",prefix),pushratingstouserplans.ToString()));
			var userItems = user.ToKeyValuePairs("user");
			keyValuePairs.AddRange(userItems);

			for(var usercompetenciesIndex = 0; usercompetenciesIndex<usercompetencies.Count;usercompetenciesIndex++) 
			{
				var usercompetenciesItem = usercompetencies[usercompetenciesIndex];
				var usercompetenciesItems = usercompetenciesItem.ToKeyValuePairs("usercompetencies[" + usercompetenciesIndex + "]");
				keyValuePairs.AddRange(usercompetenciesItems);
			}

			return keyValuePairs;
		}

	}
}
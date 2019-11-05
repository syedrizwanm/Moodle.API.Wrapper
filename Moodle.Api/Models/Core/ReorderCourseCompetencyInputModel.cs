using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ReorderCourseCompetencyInputModel : IModel 
	{
		public int competencyidfrom {get;set;}
		public int competencyidto {get;set;}
		public int courseid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyidfrom",prefix),competencyidfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyidto",prefix),competencyidto.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			return keyValuePairs;
		}

	}
}
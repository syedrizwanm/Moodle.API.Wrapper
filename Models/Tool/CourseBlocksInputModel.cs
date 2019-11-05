using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class CourseBlocksInputModel : IModel 
	{
		public int courseid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			return keyValuePairs;
		}

	}
}
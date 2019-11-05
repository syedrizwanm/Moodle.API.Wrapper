using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CoursesByFieldInputModel : IModel 
	{
		public string field {get;set;}
		public string value {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("field",prefix),field));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("value",prefix),value));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CourseModuleByInstanceInputModel : IModel 
	{
		public int instance {get;set;}
		public string module {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instance",prefix),instance.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("module",prefix),module));
			return keyValuePairs;
		}

	}
}
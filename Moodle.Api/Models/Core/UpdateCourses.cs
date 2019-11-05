using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UpdateCourses : IModel 
	{


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			return keyValuePairs;
		}

	}
}
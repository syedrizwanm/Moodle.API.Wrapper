using System.Collections.Generic;

namespace Moodle.Api.Models.Enrol
{
	public sealed class GetInstanceInfo : IModel 
	{


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			return keyValuePairs;
		}

	}
}
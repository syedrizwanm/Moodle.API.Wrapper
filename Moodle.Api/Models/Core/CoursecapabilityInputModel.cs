using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CoursecapabilityInputModel : IModel 
	{

		public List<string> capabilities {get;set;}
		public int courseid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var capabilitiesIndex = 0; capabilitiesIndex<capabilities.Count;capabilitiesIndex++) 
			{
				var capabilitiesItem = capabilities[capabilitiesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("capabilities[" + capabilitiesIndex + "]",prefix), capabilitiesItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			return keyValuePairs;
		}

	}
}
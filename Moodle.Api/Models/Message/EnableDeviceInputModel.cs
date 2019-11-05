using System.Collections.Generic;

namespace Moodle.Api.Models.Message
{
	public sealed class EnableDeviceInputModel : IModel 
	{
		public int deviceid {get;set;}
		public int enable {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("deviceid",prefix),deviceid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enable",prefix),enable.ToString()));
			return keyValuePairs;
		}

	}
}
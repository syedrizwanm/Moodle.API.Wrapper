using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class EventInputModel : IModel 
	{

		public int eventid {get;set;}
		public int repeat {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("eventid",prefix),eventid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("repeat",prefix),repeat.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserDatesInputModel : IModel 
	{
		public int contextid {get;set;}
		public string contextlevel {get;set;}
		public int instanceid {get;set;}
		public List<TimestampInputModel> timestamps {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextlevel",prefix),contextlevel));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instanceid",prefix),instanceid.ToString()));

			for(var timestampsIndex = 0; timestampsIndex<timestamps.Count;timestampsIndex++) 
			{
				var timestampsItem = timestamps[timestampsIndex];
				var timestampsItems = timestampsItem.ToKeyValuePairs("timestamps[" + timestampsIndex + "]");
				keyValuePairs.AddRange(timestampsItems);
			}

			return keyValuePairs;
		}

	}
}
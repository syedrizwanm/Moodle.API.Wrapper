using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Notification : IModel 
	{

		public string displayname {get;set;}
		public string preferencekey {get;set;}
		public List<Processor> processors {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayname",prefix),displayname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("preferencekey",prefix),preferencekey));

			for(var processorsIndex = 0; processorsIndex<processors.Count;processorsIndex++) 
			{
				var processorsItem = processors[processorsIndex];
				var processorsItems = processorsItem.ToKeyValuePairs("processors[" + processorsIndex + "]");
				keyValuePairs.AddRange(processorsItems);
			}

			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DefinitionsInputModel : IModel 
	{
		public int activeonly {get;set;}
		public string areaname {get;set;}
		public List<int> cmids {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("activeonly",prefix),activeonly.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("areaname",prefix),areaname));

			for(var cmidsIndex = 0; cmidsIndex<cmids.Count;cmidsIndex++) 
			{
				var cmidsItem = cmids[cmidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cmids[" + cmidsIndex + "]",prefix), cmidsItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}
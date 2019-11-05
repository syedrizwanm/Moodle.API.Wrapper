using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Assignment : IModel 
	{

		public int assignmentid {get;set;}
		public List<Mapping> mappings {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignmentid",prefix),assignmentid.ToString()));

			for(var mappingsIndex = 0; mappingsIndex<mappings.Count;mappingsIndex++) 
			{
				var mappingsItem = mappings[mappingsIndex];
				var mappingsItems = mappingsItem.ToKeyValuePairs("mappings[" + mappingsIndex + "]");
				keyValuePairs.AddRange(mappingsItems);
			}

			return keyValuePairs;
		}

	}
}
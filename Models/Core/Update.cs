using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Update : IModel 
	{

		public List<int> itemids {get;set;}
		public string name {get;set;}
		public int timeupdated {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var itemidsIndex = 0; itemidsIndex<itemids.Count;itemidsIndex++) 
			{
				var itemidsItem = itemids[itemidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemids[" + itemidsIndex + "]",prefix), itemidsItem.ToString()));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeupdated",prefix),timeupdated.ToString()));
			return keyValuePairs;
		}

	}
}
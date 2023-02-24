using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Itemsdata : IModel 
	{

		public List<string> data {get;set;}
		public Item item {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var dataIndex = 0; dataIndex<data.Count;dataIndex++) 
			{
				var dataItem = data[dataIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("data[" + dataIndex + "]",prefix), dataItem));
			}

			var itemItems = item.ToKeyValuePairs("item");
			keyValuePairs.AddRange(itemItems);
			return keyValuePairs;
		}

	}
}
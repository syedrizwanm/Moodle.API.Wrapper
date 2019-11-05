using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class EntryInputModel : IModel 
	{

		public List<DatumInputModel> data {get;set;}
		public int entryid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var dataIndex = 0; dataIndex<data.Count;dataIndex++) 
			{
				var dataItem = data[dataIndex];
				var dataItems = dataItem.ToKeyValuePairs("data[" + dataIndex + "]");
				keyValuePairs.AddRange(dataItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("entryid",prefix),entryid.ToString()));
			return keyValuePairs;
		}

	}
}
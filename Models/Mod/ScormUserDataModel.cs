using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ScormUserDataModel : IModel 
	{
		public List<Data> data {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var dataIndex = 0; dataIndex<data.Count;dataIndex++) 
			{
				var dataItem = data[dataIndex];
				var dataItems = dataItem.ToKeyValuePairs("data[" + dataIndex + "]");
				keyValuePairs.AddRange(dataItems);
			}


			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}
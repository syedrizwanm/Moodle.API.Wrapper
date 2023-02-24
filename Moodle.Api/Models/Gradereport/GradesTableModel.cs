using System.Collections.Generic;

namespace Moodle.Api.Models.Gradereport
{
	public sealed class GradesTableModel : IModel 
	{
		public List<Table> tables {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var tablesIndex = 0; tablesIndex<tables.Count;tablesIndex++) 
			{
				var tablesItem = tables[tablesIndex];
				var tablesItems = tablesItem.ToKeyValuePairs("tables[" + tablesIndex + "]");
				keyValuePairs.AddRange(tablesItems);
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
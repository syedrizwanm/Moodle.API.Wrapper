using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class DatabasesByCoursesModel : IModel 
	{
		public List<Database> databases {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var databasesIndex = 0; databasesIndex<databases.Count;databasesIndex++) 
			{
				var databasesItem = databases[databasesIndex];
				var databasesItems = databasesItem.ToKeyValuePairs("databases[" + databasesIndex + "]");
				keyValuePairs.AddRange(databasesItems);
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
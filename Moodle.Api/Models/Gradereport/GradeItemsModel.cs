using System.Collections.Generic;

namespace Moodle.Api.Models.Gradereport
{
	public sealed class GradeItemsModel : IModel 
	{
		public List<Usergrade> usergrades {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var usergradesIndex = 0; usergradesIndex<usergrades.Count;usergradesIndex++) 
			{
				var usergradesItem = usergrades[usergradesIndex];
				var usergradesItems = usergradesItem.ToKeyValuePairs("usergrades[" + usergradesIndex + "]");
				keyValuePairs.AddRange(usergradesItems);
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
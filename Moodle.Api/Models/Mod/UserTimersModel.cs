using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class UserTimersModel : IModel 
	{
		public List<Timer> timers {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var timersIndex = 0; timersIndex<timers.Count;timersIndex++) 
			{
				var timersItem = timers[timersIndex];
				var timersItems = timersItem.ToKeyValuePairs("timers[" + timersIndex + "]");
				keyValuePairs.AddRange(timersItems);
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
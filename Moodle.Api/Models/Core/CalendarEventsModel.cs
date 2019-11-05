using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CalendarEventsModel : IModel 
	{
		public List<Event> events {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var eventsIndex = 0; eventsIndex<events.Count;eventsIndex++) 
			{
				var eventsItem = events[eventsIndex];
				var eventsItems = eventsItem.ToKeyValuePairs("events[" + eventsIndex + "]");
				keyValuePairs.AddRange(eventsItems);
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
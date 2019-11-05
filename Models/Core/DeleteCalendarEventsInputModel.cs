using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DeleteCalendarEventsInputModel : IModel 
	{
		public List<EventInputModel> events {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var eventsIndex = 0; eventsIndex<events.Count;eventsIndex++) 
			{
				var eventsItem = events[eventsIndex];
				var eventsItems = eventsItem.ToKeyValuePairs("events[" + eventsIndex + "]");
				keyValuePairs.AddRange(eventsItems);
			}

			return keyValuePairs;
		}

	}
}
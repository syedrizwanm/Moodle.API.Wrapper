using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CalendarEventsInputModel : IModel 
	{

		public EventInputModel events {get;set;}
		public OptionInputModel options {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var eventsItems = events.ToKeyValuePairs("events");
			keyValuePairs.AddRange(eventsItems);
			var optionsItems = options.ToKeyValuePairs("options");
			keyValuePairs.AddRange(optionsItems);
			return keyValuePairs;
		}

	}
}
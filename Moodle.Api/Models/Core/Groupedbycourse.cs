using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Groupedbycourse : IModel 
	{

		public int courseid {get;set;}
		public List<Event> events {get;set;}
		public int firstid {get;set;}
		public int lastid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));

			for(var eventsIndex = 0; eventsIndex<events.Count;eventsIndex++) 
			{
				var eventsItem = events[eventsIndex];
				var eventsItems = eventsItem.ToKeyValuePairs("events[" + eventsIndex + "]");
				keyValuePairs.AddRange(eventsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("firstid",prefix),firstid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastid",prefix),lastid.ToString()));
			return keyValuePairs;
		}

	}
}
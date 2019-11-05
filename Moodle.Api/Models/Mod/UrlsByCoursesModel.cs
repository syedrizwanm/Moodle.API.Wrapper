using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class UrlsByCoursesModel : IModel 
	{
		public List<Url> urls {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var urlsIndex = 0; urlsIndex<urls.Count;urlsIndex++) 
			{
				var urlsItem = urls[urlsIndex];
				var urlsItems = urlsItem.ToKeyValuePairs("urls[" + urlsIndex + "]");
				keyValuePairs.AddRange(urlsItems);
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
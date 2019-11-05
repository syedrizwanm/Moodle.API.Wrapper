using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class PagesByCoursesModel : IModel 
	{
		public List<Page> pages {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var pagesIndex = 0; pagesIndex<pages.Count;pagesIndex++) 
			{
				var pagesItem = pages[pagesIndex];
				var pagesItems = pagesItem.ToKeyValuePairs("pages[" + pagesIndex + "]");
				keyValuePairs.AddRange(pagesItems);
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
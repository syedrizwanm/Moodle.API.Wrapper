using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class WikisByCoursesModel : IModel 
	{
		public List<Warning> warnings {get;set;}
		public List<Wiki> wikis {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}


			for(var wikisIndex = 0; wikisIndex<wikis.Count;wikisIndex++) 
			{
				var wikisItem = wikis[wikisIndex];
				var wikisItems = wikisItem.ToKeyValuePairs("wikis[" + wikisIndex + "]");
				keyValuePairs.AddRange(wikisItems);
			}

			return keyValuePairs;
		}

	}
}
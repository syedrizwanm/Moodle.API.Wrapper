using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubwikisModel : IModel 
	{
		public List<Subwiki> subwikis {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var subwikisIndex = 0; subwikisIndex<subwikis.Count;subwikisIndex++) 
			{
				var subwikisItem = subwikis[subwikisIndex];
				var subwikisItems = subwikisItem.ToKeyValuePairs("subwikis[" + subwikisIndex + "]");
				keyValuePairs.AddRange(subwikisItems);
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
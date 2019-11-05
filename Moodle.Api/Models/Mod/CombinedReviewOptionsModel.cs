using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class CombinedReviewOptionsModel : IModel 
	{
		public List<Alloption> alloptions {get;set;}
		public List<Someoption> someoptions {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var alloptionsIndex = 0; alloptionsIndex<alloptions.Count;alloptionsIndex++) 
			{
				var alloptionsItem = alloptions[alloptionsIndex];
				var alloptionsItems = alloptionsItem.ToKeyValuePairs("alloptions[" + alloptionsIndex + "]");
				keyValuePairs.AddRange(alloptionsItems);
			}


			for(var someoptionsIndex = 0; someoptionsIndex<someoptions.Count;someoptionsIndex++) 
			{
				var someoptionsItem = someoptions[someoptionsIndex];
				var someoptionsItems = someoptionsItem.ToKeyValuePairs("someoptions[" + someoptionsIndex + "]");
				keyValuePairs.AddRange(someoptionsItems);
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
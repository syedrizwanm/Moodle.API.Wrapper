using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class InsertScormTracksModel : IModel 
	{
		public List<int> trackids {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var trackidsIndex = 0; trackidsIndex<trackids.Count;trackidsIndex++) 
			{
				var trackidsItem = trackids[trackidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("trackids[" + trackidsIndex + "]",prefix), trackidsItem.ToString()));
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
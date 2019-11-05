using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Datum : IModel 
	{

		public int attempt {get;set;}
		public List<Track> tracks {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attempt",prefix),attempt.ToString()));

			for(var tracksIndex = 0; tracksIndex<tracks.Count;tracksIndex++) 
			{
				var tracksItem = tracks[tracksIndex];
				var tracksItems = tracksItem.ToKeyValuePairs("tracks[" + tracksIndex + "]");
				keyValuePairs.AddRange(tracksItems);
			}

			return keyValuePairs;
		}

	}
}
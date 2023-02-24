using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class InsertScormTracksInputModel : IModel 
	{
		public int attempt {get;set;}
		public int scoid {get;set;}
		public List<TrackInputModel> tracks {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attempt",prefix),attempt.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scoid",prefix),scoid.ToString()));

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
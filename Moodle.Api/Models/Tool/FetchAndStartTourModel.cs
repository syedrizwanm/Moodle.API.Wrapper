using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class FetchAndStartTourModel : IModel 
	{
		public Tourconfig tourconfig {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var tourconfigItems = tourconfig.ToKeyValuePairs("tourconfig");
			keyValuePairs.AddRange(tourconfigItems);
			return keyValuePairs;
		}

	}
}
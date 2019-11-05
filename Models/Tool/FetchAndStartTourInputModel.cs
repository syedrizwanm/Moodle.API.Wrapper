using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class FetchAndStartTourInputModel : IModel 
	{
		public int context {get;set;}
		public string pageurl {get;set;}
		public int tourid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("context",prefix),context.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pageurl",prefix),pageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("tourid",prefix),tourid.ToString()));
			return keyValuePairs;
		}

	}
}
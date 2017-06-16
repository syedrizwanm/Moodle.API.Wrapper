using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class SubwikisInputModel : IModel 
	{
		public int wikiid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("wikiid",prefix),wikiid.ToString()));
			return keyValuePairs;
		}

	}
}
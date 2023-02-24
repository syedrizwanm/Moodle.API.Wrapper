using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ScormUserDataInputModel : IModel 
	{
		public int attempt {get;set;}
		public int scormid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attempt",prefix),attempt.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scormid",prefix),scormid.ToString()));
			return keyValuePairs;
		}

	}
}
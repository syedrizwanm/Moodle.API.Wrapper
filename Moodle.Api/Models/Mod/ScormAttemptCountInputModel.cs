using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ScormAttemptCountInputModel : IModel 
	{
		public int ignoremissingcompletion {get;set;}
		public int scormid {get;set;}
		public int userid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ignoremissingcompletion",prefix),ignoremissingcompletion.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scormid",prefix),scormid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
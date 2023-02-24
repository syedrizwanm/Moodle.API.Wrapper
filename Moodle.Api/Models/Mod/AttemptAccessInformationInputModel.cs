using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AttemptAccessInformationInputModel : IModel 
	{
		public int attemptid {get;set;}
		public int quizid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attemptid",prefix),attemptid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("quizid",prefix),quizid.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class UserAttemptsInputModel : IModel 
	{
		public int includepreviews {get;set;}
		public int quizid {get;set;}
		public string status {get;set;}
		public int userid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includepreviews",prefix),includepreviews.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("quizid",prefix),quizid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
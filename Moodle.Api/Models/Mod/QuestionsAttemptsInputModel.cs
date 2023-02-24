using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class QuestionsAttemptsInputModel : IModel 
	{
		public int attempt {get;set;}
		public int correct {get;set;}
		public int lessonid {get;set;}
		public int pageid {get;set;}
		public int userid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attempt",prefix),attempt.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("correct",prefix),correct.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lessonid",prefix),lessonid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pageid",prefix),pageid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
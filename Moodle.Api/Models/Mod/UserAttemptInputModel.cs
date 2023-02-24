using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class UserAttemptInputModel : IModel 
	{
		public int lessonattempt {get;set;}
		public int lessonid {get;set;}
		public int userid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lessonattempt",prefix),lessonattempt.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lessonid",prefix),lessonid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AttemptsOverviewInputModel : IModel 
	{
		public int groupid {get;set;}
		public int lessonid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lessonid",prefix),lessonid.ToString()));
			return keyValuePairs;
		}

	}
}
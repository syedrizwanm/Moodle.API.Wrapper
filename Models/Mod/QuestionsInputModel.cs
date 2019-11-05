using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class QuestionsInputModel : IModel 
	{
		public int surveyid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("surveyid",prefix),surveyid.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubmitAnswersInputModel : IModel 
	{
		public List<AnswerInputModel> answers {get;set;}
		public int surveyid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var answersIndex = 0; answersIndex<answers.Count;answersIndex++) 
			{
				var answersItem = answers[answersIndex];
				var answersItems = answersItem.ToKeyValuePairs("answers[" + answersIndex + "]");
				keyValuePairs.AddRange(answersItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("surveyid",prefix),surveyid.ToString()));
			return keyValuePairs;
		}

	}
}
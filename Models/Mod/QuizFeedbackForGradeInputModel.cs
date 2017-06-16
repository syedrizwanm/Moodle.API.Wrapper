using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class QuizFeedbackForGradeInputModel : IModel 
	{
		public double grade {get;set;}
		public int quizid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("quizid",prefix),quizid.ToString()));
			return keyValuePairs;
		}

	}
}
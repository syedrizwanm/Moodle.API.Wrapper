using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Answerdata : IModel 
	{

		public List<Answer> answers {get;set;}
		public string response {get;set;}
		public int responseformat {get;set;}
		public string score {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var answersIndex = 0; answersIndex<answers.Count;answersIndex++) 
			{
				var answersItem = answers[answersIndex];
				var answersItems = answersItem.ToKeyValuePairs("answers[" + answersIndex + "]");
				keyValuePairs.AddRange(answersItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("response",prefix),response));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("responseformat",prefix),responseformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("score",prefix),score));
			return keyValuePairs;
		}

	}
}
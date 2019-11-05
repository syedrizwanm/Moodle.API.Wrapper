using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class QuizzesByCoursesModel : IModel 
	{
		public List<Quizze> quizzes {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var quizzesIndex = 0; quizzesIndex<quizzes.Count;quizzesIndex++) 
			{
				var quizzesItem = quizzes[quizzesIndex];
				var quizzesItems = quizzesItem.ToKeyValuePairs("quizzes[" + quizzesIndex + "]");
				keyValuePairs.AddRange(quizzesItems);
			}


			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}
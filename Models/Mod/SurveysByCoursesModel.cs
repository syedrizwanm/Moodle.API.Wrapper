using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SurveysByCoursesModel : IModel 
	{
		public List<Survey> surveys {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var surveysIndex = 0; surveysIndex<surveys.Count;surveysIndex++) 
			{
				var surveysItem = surveys[surveysIndex];
				var surveysItems = surveysItem.ToKeyValuePairs("surveys[" + surveysIndex + "]");
				keyValuePairs.AddRange(surveysItems);
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
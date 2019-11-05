using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class QuizRequiredQtypesModel : IModel 
	{
		public List<string> questiontypes {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var questiontypesIndex = 0; questiontypesIndex<questiontypes.Count;questiontypesIndex++) 
			{
				var questiontypesItem = questiontypes[questiontypesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("questiontypes[" + questiontypesIndex + "]",prefix), questiontypesItem));
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
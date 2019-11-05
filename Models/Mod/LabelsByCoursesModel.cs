using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class LabelsByCoursesModel : IModel 
	{
		public List<Label> labels {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var labelsIndex = 0; labelsIndex<labels.Count;labelsIndex++) 
			{
				var labelsItem = labels[labelsIndex];
				var labelsItems = labelsItem.ToKeyValuePairs("labels[" + labelsIndex + "]");
				keyValuePairs.AddRange(labelsItems);
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
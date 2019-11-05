using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ImscpsByCoursesModel : IModel 
	{
		public List<Imscp> imscps {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var imscpsIndex = 0; imscpsIndex<imscps.Count;imscpsIndex++) 
			{
				var imscpsItem = imscps[imscpsIndex];
				var imscpsItems = imscpsItem.ToKeyValuePairs("imscps[" + imscpsIndex + "]");
				keyValuePairs.AddRange(imscpsItems);
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
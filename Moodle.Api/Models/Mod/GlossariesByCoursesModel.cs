using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class GlossariesByCoursesModel : IModel 
	{
		public List<Glossarie> glossaries {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var glossariesIndex = 0; glossariesIndex<glossaries.Count;glossariesIndex++) 
			{
				var glossariesItem = glossaries[glossariesIndex];
				var glossariesItems = glossariesItem.ToKeyValuePairs("glossaries[" + glossariesIndex + "]");
				keyValuePairs.AddRange(glossariesItems);
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
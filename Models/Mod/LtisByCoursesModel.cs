using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class LtisByCoursesModel : IModel 
	{
		public List<Lti> ltis {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var ltisIndex = 0; ltisIndex<ltis.Count;ltisIndex++) 
			{
				var ltisItem = ltis[ltisIndex];
				var ltisItems = ltisItem.ToKeyValuePairs("ltis[" + ltisIndex + "]");
				keyValuePairs.AddRange(ltisItems);
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
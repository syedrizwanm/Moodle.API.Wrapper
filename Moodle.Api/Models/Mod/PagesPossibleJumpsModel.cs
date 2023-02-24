using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class PagesPossibleJumpsModel : IModel 
	{
		public List<Jump> jumps {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var jumpsIndex = 0; jumpsIndex<jumps.Count;jumpsIndex++) 
			{
				var jumpsItem = jumps[jumpsIndex];
				var jumpsItems = jumpsItem.ToKeyValuePairs("jumps[" + jumpsIndex + "]");
				keyValuePairs.AddRange(jumpsItems);
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
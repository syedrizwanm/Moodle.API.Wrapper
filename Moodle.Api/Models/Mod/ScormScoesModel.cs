using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ScormScoesModel : IModel 
	{
		public List<Scoe> scoes {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var scoesIndex = 0; scoesIndex<scoes.Count;scoesIndex++) 
			{
				var scoesItem = scoes[scoesIndex];
				var scoesItems = scoesItem.ToKeyValuePairs("scoes[" + scoesIndex + "]");
				keyValuePairs.AddRange(scoesItems);
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
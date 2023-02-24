using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForRelatedCompetenciesSectionModel : IModel 
	{
		public List<Relatedcompetencie> relatedcompetencies {get;set;}
		public int showdeleterelatedaction {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var relatedcompetenciesIndex = 0; relatedcompetenciesIndex<relatedcompetencies.Count;relatedcompetenciesIndex++) 
			{
				var relatedcompetenciesItem = relatedcompetencies[relatedcompetenciesIndex];
				var relatedcompetenciesItems = relatedcompetenciesItem.ToKeyValuePairs("relatedcompetencies[" + relatedcompetenciesIndex + "]");
				keyValuePairs.AddRange(relatedcompetenciesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("showdeleterelatedaction",prefix),showdeleterelatedaction.ToString()));
			return keyValuePairs;
		}

	}
}
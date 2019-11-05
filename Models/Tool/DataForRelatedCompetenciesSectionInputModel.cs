using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForRelatedCompetenciesSectionInputModel : IModel 
	{
		public int competencyid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyid",prefix),competencyid.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class RelatedCompetencyInputModel : IModel 
	{
		public int competencyid {get;set;}
		public int relatedcompetencyid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyid",prefix),competencyid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("relatedcompetencyid",prefix),relatedcompetencyid.ToString()));
			return keyValuePairs;
		}

	}
}
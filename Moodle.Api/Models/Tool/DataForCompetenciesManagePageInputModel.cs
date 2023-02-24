using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForCompetenciesManagePageInputModel : IModel 
	{
		public int competencyframeworkid {get;set;}
		public string search {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyframeworkid",prefix),competencyframeworkid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("search",prefix),search));
			return keyValuePairs;
		}

	}
}
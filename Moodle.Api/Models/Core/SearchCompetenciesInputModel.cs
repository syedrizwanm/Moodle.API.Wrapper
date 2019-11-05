using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SearchCompetenciesInputModel : IModel 
	{
		public int competencyframeworkid {get;set;}
		public string searchtext {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyframeworkid",prefix),competencyframeworkid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("searchtext",prefix),searchtext));
			return keyValuePairs;
		}

	}
}
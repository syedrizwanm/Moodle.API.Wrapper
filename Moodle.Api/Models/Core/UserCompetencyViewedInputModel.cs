using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserCompetencyViewedInputModel : IModel 
	{
		public int usercompetencyid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usercompetencyid",prefix),usercompetencyid.ToString()));
			return keyValuePairs;
		}

	}
}
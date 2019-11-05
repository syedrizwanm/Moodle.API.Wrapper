using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserEvidenceCompetencyInputModel : IModel 
	{
		public int competencyid {get;set;}
		public int userevidenceid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyid",prefix),competencyid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userevidenceid",prefix),userevidenceid.ToString()));
			return keyValuePairs;
		}

	}
}
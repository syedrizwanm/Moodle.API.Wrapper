using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class DataAccessInformationInputModel : IModel 
	{
		public int databaseid {get;set;}
		public int groupid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("databaseid",prefix),databaseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			return keyValuePairs;
		}

	}
}
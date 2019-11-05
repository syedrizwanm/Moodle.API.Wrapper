using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ApproveEntryInputModel : IModel 
	{
		public int approve {get;set;}
		public int entryid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("approve",prefix),approve.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("entryid",prefix),entryid.ToString()));
			return keyValuePairs;
		}

	}
}
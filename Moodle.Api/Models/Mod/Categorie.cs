using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Categorie : IModel 
	{

		public int glossaryid {get;set;}
		public int id {get;set;}
		public string name {get;set;}
		public int usedynalink {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("glossaryid",prefix),glossaryid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usedynalink",prefix),usedynalink.ToString()));
			return keyValuePairs;
		}

	}
}
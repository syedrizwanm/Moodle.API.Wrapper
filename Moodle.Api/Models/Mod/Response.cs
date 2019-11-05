using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Response : IModel 
	{

		public int id {get;set;}
		public string name {get;set;}
		public string printval {get;set;}
		public string rawval {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("printval",prefix),printval));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rawval",prefix),rawval));
			return keyValuePairs;
		}

	}
}
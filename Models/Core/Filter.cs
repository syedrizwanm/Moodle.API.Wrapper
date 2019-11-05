using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Filter : IModel 
	{

		public string filter {get;set;}
		public int inheritedstate {get;set;}
		public int localstate {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filter",prefix),filter));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("inheritedstate",prefix),inheritedstate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("localstate",prefix),localstate.ToString()));
			return keyValuePairs;
		}

	}
}
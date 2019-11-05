using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Option : IModel 
	{

		public int available {get;set;}
		public string name {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("available",prefix),available.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			return keyValuePairs;
		}

	}
}
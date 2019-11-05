using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Function : IModel 
	{

		public string name {get;set;}
		public string version {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("version",prefix),version));
			return keyValuePairs;
		}

	}
}
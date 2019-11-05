using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Advancedgrading : IModel 
	{

		public string area {get;set;}
		public string method {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("area",prefix),area));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("method",prefix),method));
			return keyValuePairs;
		}

	}
}
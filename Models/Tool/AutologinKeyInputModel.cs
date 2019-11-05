using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class AutologinKeyInputModel : IModel 
	{
		public string privatetoken {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("privatetoken",prefix),privatetoken));
			return keyValuePairs;
		}

	}
}
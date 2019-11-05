using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class ConfigInputModel : IModel 
	{
		public string section {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Ruleoutcomeoption : IModel 
	{

		public int selected {get;set;}
		public string text {get;set;}
		public int value {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("selected",prefix),selected.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("value",prefix),value.ToString()));
			return keyValuePairs;
		}

	}
}
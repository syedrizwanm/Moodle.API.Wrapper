using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ComponentStringsInputModel : IModel 
	{
		public string component {get;set;}
		public string lang {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lang",prefix),lang));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class IsCartridgeInputModel : IModel 
	{
		public string url {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class LoadFontawesomeIconMapModel : IModel 
	{
		public string component {get;set;}
		public string pix {get;set;}
		public string to {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pix",prefix),pix));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("to",prefix),to));
			return keyValuePairs;
		}

	}
}
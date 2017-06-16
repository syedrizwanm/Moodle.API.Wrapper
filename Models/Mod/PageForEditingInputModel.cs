using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class PageForEditingInputModel : IModel 
	{
		public int lockonly {get;set;}
		public int pageid {get;set;}
		public string section {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lockonly",prefix),lockonly.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pageid",prefix),pageid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section));
			return keyValuePairs;
		}

	}
}
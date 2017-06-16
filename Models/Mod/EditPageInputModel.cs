using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class EditPageInputModel : IModel 
	{
		public string content {get;set;}
		public int pageid {get;set;}
		public string section {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content",prefix),content));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pageid",prefix),pageid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section));
			return keyValuePairs;
		}

	}
}
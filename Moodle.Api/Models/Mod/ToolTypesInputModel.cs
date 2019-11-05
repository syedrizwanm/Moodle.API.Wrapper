using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ToolTypesInputModel : IModel 
	{
		public int toolproxyid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("toolproxyid",prefix),toolproxyid.ToString()));
			return keyValuePairs;
		}

	}
}
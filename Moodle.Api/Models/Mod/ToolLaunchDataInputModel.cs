using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ToolLaunchDataInputModel : IModel 
	{
		public int toolid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("toolid",prefix),toolid.ToString()));
			return keyValuePairs;
		}

	}
}
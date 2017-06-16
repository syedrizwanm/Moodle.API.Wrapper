using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class ToolProxiesInputModel : IModel 
	{
		public int orphanedonly {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("orphanedonly",prefix),orphanedonly.ToString()));
			return keyValuePairs;
		}

	}
}
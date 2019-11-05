using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Jump : IModel 
	{

		public int answerid {get;set;}
		public int calculatedjump {get;set;}
		public int jumpto {get;set;}
		public int pageid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("answerid",prefix),answerid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("calculatedjump",prefix),calculatedjump.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("jumpto",prefix),jumpto.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pageid",prefix),pageid.ToString()));
			return keyValuePairs;
		}

	}
}
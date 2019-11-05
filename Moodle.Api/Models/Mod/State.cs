using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class State : IModel 
	{

		public int configured {get;set;}
		public int pending {get;set;}
		public int rejected {get;set;}
		public string text {get;set;}
		public int unknown {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("configured",prefix),configured.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pending",prefix),pending.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rejected",prefix),rejected.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("unknown",prefix),unknown.ToString()));
			return keyValuePairs;
		}

	}
}
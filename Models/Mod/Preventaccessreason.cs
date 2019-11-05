using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Preventaccessreason : IModel 
	{

		public string data {get;set;}
		public string message {get;set;}
		public string reason {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("data",prefix),data));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("message",prefix),message));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reason",prefix),reason));
			return keyValuePairs;
		}

	}
}
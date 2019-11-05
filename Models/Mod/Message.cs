using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Message : IModel 
	{

		public string message {get;set;}
		public string type {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("message",prefix),message));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type));
			return keyValuePairs;
		}

	}
}
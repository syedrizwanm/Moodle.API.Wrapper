using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Variable : IModel 
	{

		public string announce {get;set;}
		public string closebutton {get;set;}
		public string extraclasses {get;set;}
		public string message {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("announce",prefix),announce));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("closebutton",prefix),closebutton));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("extraclasses",prefix),extraclasses));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("message",prefix),message));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class FlagInputModel : IModel 
	{
		public string checksum {get;set;}
		public int newstate {get;set;}
		public int qaid {get;set;}
		public int qubaid {get;set;}
		public int questionid {get;set;}
		public int slot {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("checksum",prefix),checksum));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("newstate",prefix),newstate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("qaid",prefix),qaid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("qubaid",prefix),qubaid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("questionid",prefix),questionid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("slot",prefix),slot.ToString()));
			return keyValuePairs;
		}

	}
}
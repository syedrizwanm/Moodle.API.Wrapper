using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class SendInstantMessagesModel : IModel 
	{
		public string clientmsgid {get;set;}
		public string errormessage {get;set;}
		public int msgid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("clientmsgid",prefix),clientmsgid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("errormessage",prefix),errormessage));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("msgid",prefix),msgid.ToString()));
			return keyValuePairs;
		}

	}
}
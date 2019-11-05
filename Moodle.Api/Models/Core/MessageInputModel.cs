using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class MessageInputModel : IModel 
	{

		public string clientmsgid {get;set;}
		public string text {get;set;}
		public int textformat {get;set;}
		public int touserid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("clientmsgid",prefix),clientmsgid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("textformat",prefix),textformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("touserid",prefix),touserid.ToString()));
			return keyValuePairs;
		}

	}
}
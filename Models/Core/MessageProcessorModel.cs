using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class MessageProcessorModel : IModel 
	{
		public int systemconfigured {get;set;}
		public int userconfigured {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("systemconfigured",prefix),systemconfigured.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userconfigured",prefix),userconfigured.ToString()));
			return keyValuePairs;
		}

	}
}
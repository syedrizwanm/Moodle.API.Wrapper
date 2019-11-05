using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class MarkMessageReadInputModel : IModel 
	{
		public int messageid {get;set;}
		public int timeread {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("messageid",prefix),messageid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeread",prefix),timeread.ToString()));
			return keyValuePairs;
		}

	}
}
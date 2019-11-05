using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Detail : IModel 
	{

		public string criteria {get;set;}
		public string requirement {get;set;}
		public string status {get;set;}
		public string type {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("criteria",prefix),criteria));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("requirement",prefix),requirement));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type));
			return keyValuePairs;
		}

	}
}
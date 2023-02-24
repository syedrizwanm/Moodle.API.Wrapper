using System.Collections.Generic;

namespace Moodle.Api.Models.Report
{
	public sealed class Ancestor : IModel 
	{

		public int first {get;set;}
		public int id {get;set;}
		public int last {get;set;}
		public string name {get;set;}
		public int position {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("first",prefix),first.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("last",prefix),last.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("position",prefix),position.ToString()));
			return keyValuePairs;
		}

	}
}
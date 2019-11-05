using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Config : IModel 
	{

		public int assignment {get;set;}
		public int id {get;set;}
		public string name {get;set;}
		public string plugin {get;set;}
		public string subtype {get;set;}
		public string value {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignment",prefix),assignment.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("plugin",prefix),plugin));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("subtype",prefix),subtype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("value",prefix),value));
			return keyValuePairs;
		}

	}
}
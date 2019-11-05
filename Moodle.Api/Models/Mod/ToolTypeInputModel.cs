using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ToolTypeInputModel : IModel 
	{

		public string description {get;set;}
		public int id {get;set;}
		public string name {get;set;}
		public int state {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("state",prefix),state.ToString()));
			return keyValuePairs;
		}

	}
}
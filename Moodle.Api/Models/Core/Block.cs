using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Block : IModel 
	{

		public int collapsible {get;set;}
		public int dockable {get;set;}
		public int instanceid {get;set;}
		public string name {get;set;}
		public int positionid {get;set;}
		public string region {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("collapsible",prefix),collapsible.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dockable",prefix),dockable.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instanceid",prefix),instanceid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("positionid",prefix),positionid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("region",prefix),region));
			return keyValuePairs;
		}

	}
}
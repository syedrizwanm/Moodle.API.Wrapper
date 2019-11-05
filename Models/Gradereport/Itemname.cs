using System.Collections.Generic;

namespace Moodle.Api.Models.Gradereport
{
	public sealed class Itemname : IModel 
	{

		public string @class {get;set;}
		public string celltype {get;set;}
		public int colspan {get;set;}
		public string content {get;set;}
		public string id {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("@class",prefix),@class));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("celltype",prefix),celltype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("colspan",prefix),colspan.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content",prefix),content));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id));
			return keyValuePairs;
		}

	}
}
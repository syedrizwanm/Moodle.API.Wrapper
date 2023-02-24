using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Parent : IModel 
	{

		public string component {get;set;}
		public int contextid {get;set;}
		public string filearea {get;set;}
		public string filename {get;set;}
		public string filepath {get;set;}
		public int itemid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filearea",prefix),filearea));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filename",prefix),filename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filepath",prefix),filepath));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid.ToString()));
			return keyValuePairs;
		}

	}
}
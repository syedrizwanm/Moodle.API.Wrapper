using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Plugin : IModel 
	{

		public string addon {get;set;}
		public string component {get;set;}
		public List<string> dependencies {get;set;}
		public string filehash {get;set;}
		public int filesize {get;set;}
		public string fileurl {get;set;}
		public string version {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("addon",prefix),addon));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));

			for(var dependenciesIndex = 0; dependenciesIndex<dependencies.Count;dependenciesIndex++) 
			{
				var dependenciesItem = dependencies[dependenciesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dependencies[" + dependenciesIndex + "]",prefix), dependenciesItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filehash",prefix),filehash));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filesize",prefix),filesize.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fileurl",prefix),fileurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("version",prefix),version));
			return keyValuePairs;
		}

	}
}
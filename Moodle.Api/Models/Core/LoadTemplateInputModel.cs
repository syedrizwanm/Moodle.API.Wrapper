using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class LoadTemplateInputModel : IModel 
	{
		public string component {get;set;}
		public string template {get;set;}
		public string themename {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("template",prefix),template));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("themename",prefix),themename));
			return keyValuePairs;
		}

	}
}
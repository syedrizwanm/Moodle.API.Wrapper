using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class EntriesByTermInputModel : IModel 
	{
		public int from {get;set;}
		public int id {get;set;}
		public int limit {get;set;}
		public OptionInputModel options {get;set;}
		public string term {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("from",prefix),from.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limit",prefix),limit.ToString()));
			var optionsItems = options.ToKeyValuePairs("options");
			keyValuePairs.AddRange(optionsItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("term",prefix),term));
			return keyValuePairs;
		}

	}
}
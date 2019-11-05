using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class StringInputModel : IModel 
	{

		public string component {get;set;}
		public string lang {get;set;}
		public string stringid {get;set;}
		public List<StringparamInputModel> stringparams {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lang",prefix),lang));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("stringid",prefix),stringid));

			for(var stringparamsIndex = 0; stringparamsIndex<stringparams.Count;stringparamsIndex++) 
			{
				var stringparamsItem = stringparams[stringparamsIndex];
				var stringparamsItems = stringparamsItem.ToKeyValuePairs("stringparams[" + stringparamsIndex + "]");
				keyValuePairs.AddRange(stringparamsItems);
			}

			return keyValuePairs;
		}

	}
}
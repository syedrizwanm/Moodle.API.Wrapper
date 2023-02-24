using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class AreaInputModel : IModel 
	{

		public string activemethod {get;set;}
		public string areaname {get;set;}
		public int cmid {get;set;}
		public string component {get;set;}
		public int contextid {get;set;}
		public List<DefinitionInputModel> definitions {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("activemethod",prefix),activemethod));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("areaname",prefix),areaname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cmid",prefix),cmid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));

			for(var definitionsIndex = 0; definitionsIndex<definitions.Count;definitionsIndex++) 
			{
				var definitionsItem = definitions[definitionsIndex];
				var definitionsItems = definitionsItem.ToKeyValuePairs("definitions[" + definitionsIndex + "]");
				keyValuePairs.AddRange(definitionsItems);
			}

			return keyValuePairs;
		}

	}
}
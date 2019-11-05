using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Field : IModel 
	{

		public int dataid {get;set;}
		public string description {get;set;}
		public int id {get;set;}
		public string name {get;set;}
		public string param1 {get;set;}
		public string param10 {get;set;}
		public string param2 {get;set;}
		public string param3 {get;set;}
		public string param4 {get;set;}
		public string param5 {get;set;}
		public string param6 {get;set;}
		public string param7 {get;set;}
		public string param8 {get;set;}
		public string param9 {get;set;}
		public int required {get;set;}
		public string type {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dataid",prefix),dataid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param1",prefix),param1));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param10",prefix),param10));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param2",prefix),param2));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param3",prefix),param3));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param4",prefix),param4));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param5",prefix),param5));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param6",prefix),param6));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param7",prefix),param7));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param8",prefix),param8));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param9",prefix),param9));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("required",prefix),required.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type));
			return keyValuePairs;
		}

	}
}
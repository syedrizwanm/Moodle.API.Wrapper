using System.Collections.Generic;

namespace Moodle.Api.Models.Auth
{
	public sealed class Profilefield : IModel 
	{

		public int categoryid {get;set;}
		public string categoryname {get;set;}
		public string datatype {get;set;}
		public string defaultdata {get;set;}
		public int defaultdataformat {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public int forceunique {get;set;}
		public int id {get;set;}
		public int locked {get;set;}
		public string name {get;set;}
		public string param1 {get;set;}
		public string param2 {get;set;}
		public string param3 {get;set;}
		public string param4 {get;set;}
		public string param5 {get;set;}
		public int required {get;set;}
		public string shortname {get;set;}
		public int signup {get;set;}
		public int sortorder {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("categoryid",prefix),categoryid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("categoryname",prefix),categoryname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("datatype",prefix),datatype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("defaultdata",prefix),defaultdata));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("defaultdataformat",prefix),defaultdataformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("forceunique",prefix),forceunique.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("locked",prefix),locked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param1",prefix),param1));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param2",prefix),param2));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param3",prefix),param3));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param4",prefix),param4));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("param5",prefix),param5));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("required",prefix),required.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("signup",prefix),signup.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortorder",prefix),sortorder.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
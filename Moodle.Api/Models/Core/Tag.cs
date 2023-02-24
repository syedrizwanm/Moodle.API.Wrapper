using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Tag : IModel 
	{

		public string description {get;set;}
		public int descriptionformat {get;set;}
		public int flag {get;set;}
		public int id {get;set;}
		public int isstandard {get;set;}
		public string name {get;set;}
		public int official {get;set;}
		public string rawname {get;set;}
		public int tagcollid {get;set;}
		public string viewurl {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("flag",prefix),flag.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isstandard",prefix),isstandard.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("official",prefix),official.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rawname",prefix),rawname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("tagcollid",prefix),tagcollid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("viewurl",prefix),viewurl));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class InplaceEditableModel : IModel 
	{
		public string component {get;set;}
		public string displayvalue {get;set;}
		public string edithint {get;set;}
		public string editlabel {get;set;}
		public string itemid {get;set;}
		public string itemtype {get;set;}
		public int linkeverything {get;set;}
		public string options {get;set;}
		public string type {get;set;}
		public string value {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("displayvalue",prefix),displayvalue));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("edithint",prefix),edithint));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("editlabel",prefix),editlabel));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemtype",prefix),itemtype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("linkeverything",prefix),linkeverything.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("options",prefix),options));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("value",prefix),value));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ToolProxyModel : IModel 
	{
		public string capabilityoffered {get;set;}
		public string guid {get;set;}
		public int id {get;set;}
		public string name {get;set;}
		public string regurl {get;set;}
		public string secret {get;set;}
		public string serviceoffered {get;set;}
		public int state {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public string toolproxy {get;set;}
		public string vendorcode {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("capabilityoffered",prefix),capabilityoffered));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("guid",prefix),guid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("regurl",prefix),regurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("secret",prefix),secret));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("serviceoffered",prefix),serviceoffered));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("state",prefix),state.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("toolproxy",prefix),toolproxy));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("vendorcode",prefix),vendorcode));
			return keyValuePairs;
		}

	}
}
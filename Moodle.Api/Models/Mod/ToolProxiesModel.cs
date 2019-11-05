using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ToolProxiesModel : IModel 
	{
		public List<string> capabilitygroups {get;set;}
		public int courseid {get;set;}
		public string description {get;set;}
		public int hascapabilitygroups {get;set;}
		public int id {get;set;}
		public int instancecount {get;set;}
		public List<int> instanceids {get;set;}
		public string name {get;set;}
		public State state {get;set;}
		public Url urls {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var capabilitygroupsIndex = 0; capabilitygroupsIndex<capabilitygroups.Count;capabilitygroupsIndex++) 
			{
				var capabilitygroupsItem = capabilitygroups[capabilitygroupsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("capabilitygroups[" + capabilitygroupsIndex + "]",prefix), capabilitygroupsItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hascapabilitygroups",prefix),hascapabilitygroups.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instancecount",prefix),instancecount.ToString()));

			for(var instanceidsIndex = 0; instanceidsIndex<instanceids.Count;instanceidsIndex++) 
			{
				var instanceidsItem = instanceids[instanceidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instanceids[" + instanceidsIndex + "]",prefix), instanceidsItem.ToString()));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			var stateItems = state.ToKeyValuePairs("state");
			keyValuePairs.AddRange(stateItems);
			var urlsItems = urls.ToKeyValuePairs("urls");
			keyValuePairs.AddRange(urlsItems);
			return keyValuePairs;
		}

	}
}
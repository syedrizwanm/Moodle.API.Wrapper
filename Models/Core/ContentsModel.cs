using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ContentsModel : IModel 
	{
		public string availabilityinfo {get;set;}
		public int hiddenbynumsections {get;set;}
		public int id {get;set;}
		public List<Module> modules {get;set;}
		public string name {get;set;}
		public int section {get;set;}
		public string summary {get;set;}
		public int summaryformat {get;set;}
		public int uservisible {get;set;}
		public int visible {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("availabilityinfo",prefix),availabilityinfo));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hiddenbynumsections",prefix),hiddenbynumsections.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));

			for(var modulesIndex = 0; modulesIndex<modules.Count;modulesIndex++) 
			{
				var modulesItem = modules[modulesIndex];
				var modulesItems = modulesItem.ToKeyValuePairs("modules[" + modulesIndex + "]");
				keyValuePairs.AddRange(modulesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("section",prefix),section.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summary",prefix),summary));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("summaryformat",prefix),summaryformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("uservisible",prefix),uservisible.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
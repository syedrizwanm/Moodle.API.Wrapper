using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForCompetenciesManagePageModel : IModel 
	{
		public int canmanage {get;set;}
		public Framework framework {get;set;}
		public int pagecontextid {get;set;}
		public string pluginbaseurl {get;set;}
		public string rulesmodules {get;set;}
		public string search {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanage",prefix),canmanage.ToString()));
			var frameworkItems = framework.ToKeyValuePairs("framework");
			keyValuePairs.AddRange(frameworkItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pagecontextid",prefix),pagecontextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pluginbaseurl",prefix),pluginbaseurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rulesmodules",prefix),rulesmodules));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("search",prefix),search));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForCompetencyFrameworksManagePageModel : IModel 
	{
		public List<Competencyframework> competencyframeworks {get;set;}
		public List<string> navigation {get;set;}
		public int pagecontextid {get;set;}
		public string pluginbaseurl {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var competencyframeworksIndex = 0; competencyframeworksIndex<competencyframeworks.Count;competencyframeworksIndex++) 
			{
				var competencyframeworksItem = competencyframeworks[competencyframeworksIndex];
				var competencyframeworksItems = competencyframeworksItem.ToKeyValuePairs("competencyframeworks[" + competencyframeworksIndex + "]");
				keyValuePairs.AddRange(competencyframeworksItems);
			}


			for(var navigationIndex = 0; navigationIndex<navigation.Count;navigationIndex++) 
			{
				var navigationItem = navigation[navigationIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("navigation[" + navigationIndex + "]",prefix), navigationItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pagecontextid",prefix),pagecontextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pluginbaseurl",prefix),pluginbaseurl));
			return keyValuePairs;
		}

	}
}
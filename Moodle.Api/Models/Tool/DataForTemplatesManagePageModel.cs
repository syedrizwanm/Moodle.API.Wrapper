using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForTemplatesManagePageModel : IModel 
	{
		public int canmanage {get;set;}
		public List<string> navigation {get;set;}
		public int pagecontextid {get;set;}
		public string pluginbaseurl {get;set;}
		public List<Template> templates {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanage",prefix),canmanage.ToString()));

			for(var navigationIndex = 0; navigationIndex<navigation.Count;navigationIndex++) 
			{
				var navigationItem = navigation[navigationIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("navigation[" + navigationIndex + "]",prefix), navigationItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pagecontextid",prefix),pagecontextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pluginbaseurl",prefix),pluginbaseurl));

			for(var templatesIndex = 0; templatesIndex<templates.Count;templatesIndex++) 
			{
				var templatesItem = templates[templatesIndex];
				var templatesItems = templatesItem.ToKeyValuePairs("templates[" + templatesIndex + "]");
				keyValuePairs.AddRange(templatesItems);
			}

			return keyValuePairs;
		}

	}
}
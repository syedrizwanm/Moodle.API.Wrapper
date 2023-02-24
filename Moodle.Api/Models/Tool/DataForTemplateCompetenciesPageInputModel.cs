using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForTemplateCompetenciesPageInputModel : IModel 
	{
		public PagecontextInputModel pagecontext {get;set;}
		public int templateid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var pagecontextItems = pagecontext.ToKeyValuePairs("pagecontext");
			keyValuePairs.AddRange(pagecontextItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("templateid",prefix),templateid.ToString()));
			return keyValuePairs;
		}

	}
}
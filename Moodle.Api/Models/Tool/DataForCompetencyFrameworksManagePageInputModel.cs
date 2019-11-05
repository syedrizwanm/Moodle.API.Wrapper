using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForCompetencyFrameworksManagePageInputModel : IModel 
	{
		public PagecontextInputModel pagecontext {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var pagecontextItems = pagecontext.ToKeyValuePairs("pagecontext");
			keyValuePairs.AddRange(pagecontextItems);
			return keyValuePairs;
		}

	}
}
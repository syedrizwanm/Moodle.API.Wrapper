using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class PageForEditingModel : IModel 
	{
		public Pagesection pagesection {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var pagesectionItems = pagesection.ToKeyValuePairs("pagesection");
			keyValuePairs.AddRange(pagesectionItems);
			return keyValuePairs;
		}

	}
}
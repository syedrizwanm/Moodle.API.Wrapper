using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class TagindexInputModel : IModel 
	{
		public TagindexInputModelClass tagindex {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var tagindexItems = tagindex.ToKeyValuePairs("tagindex");
			keyValuePairs.AddRange(tagindexItems);
			return keyValuePairs;
		}

	}
}
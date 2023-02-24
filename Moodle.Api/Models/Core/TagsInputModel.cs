using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class TagsInputModel : IModel 
	{
		public List<TagInputModel> tags {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var tagsIndex = 0; tagsIndex<tags.Count;tagsIndex++) 
			{
				var tagsItem = tags[tagsIndex];
				var tagsItems = tagsItem.ToKeyValuePairs("tags[" + tagsIndex + "]");
				keyValuePairs.AddRange(tagsItems);
			}

			return keyValuePairs;
		}

	}
}
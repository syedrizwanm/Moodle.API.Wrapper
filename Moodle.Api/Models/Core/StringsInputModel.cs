using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class StringsInputModel : IModel 
	{
		public List<StringInputModel> strings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var stringsIndex = 0; stringsIndex<strings.Count;stringsIndex++) 
			{
				var stringsItem = strings[stringsIndex];
				var stringsItems = stringsItem.ToKeyValuePairs("strings[" + stringsIndex + "]");
				keyValuePairs.AddRange(stringsItems);
			}

			return keyValuePairs;
		}

	}
}
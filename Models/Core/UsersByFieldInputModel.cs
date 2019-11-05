using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UsersByFieldInputModel : IModel 
	{
		public string field {get;set;}
		public List<string> values {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("field",prefix),field));

			for(var valuesIndex = 0; valuesIndex<values.Count;valuesIndex++) 
			{
				var valuesItem = values[valuesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("values[" + valuesIndex + "]",prefix), valuesItem));
			}

			return keyValuePairs;
		}

	}
}
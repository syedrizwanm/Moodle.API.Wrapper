using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class CategoriesInputModel : IModel 
	{
		public int from {get;set;}
		public int id {get;set;}
		public int limit {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("from",prefix),from.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limit",prefix),limit.ToString()));
			return keyValuePairs;
		}

	}
}
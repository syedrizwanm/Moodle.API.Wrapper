using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CategoryInputModel : IModel 
	{

		public int id {get;set;}
		public int newparent {get;set;}
		public int recursive {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("newparent",prefix),newparent.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("recursive",prefix),recursive.ToString()));
			return keyValuePairs;
		}

	}
}
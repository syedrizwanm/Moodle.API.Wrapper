using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Guide_Comment : IModel 
	{

		public string description {get;set;}
		public int descriptionformat {get;set;}
		public int id {get;set;}
		public int sortorder {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortorder",prefix),sortorder.ToString()));
			return keyValuePairs;
		}

	}
}
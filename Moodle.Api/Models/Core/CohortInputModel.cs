using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CohortInputModel : IModel 
	{

		public CategorytypeInputModel categorytype {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public string name {get;set;}
		public int visible {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var categorytypeItems = categorytype.ToKeyValuePairs("categorytype");
			keyValuePairs.AddRange(categorytypeItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("visible",prefix),visible.ToString()));
			return keyValuePairs;
		}

	}
}
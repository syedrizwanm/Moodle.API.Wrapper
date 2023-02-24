using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CategoryInputModel : IModel 
	{

		public string name { get; set; }
		public int parent { get; set; } = 0;
		public string idnumber { get; set; }
		public string description { get; set; }
		public int descriptionformat { get; set; }
		public string theme { get; set; }




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name", prefix), name.ToString())); 
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("parent", prefix), parent.ToString())); 
			return keyValuePairs;
		}

	}
}
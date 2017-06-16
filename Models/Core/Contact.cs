using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class Contact : IModel 
	{

		public string fullname {get;set;}
		public int id {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			return keyValuePairs;
		}

	}
}
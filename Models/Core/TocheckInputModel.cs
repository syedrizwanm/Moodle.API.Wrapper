using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class TocheckInputModel : IModel 
	{

		public string contextlevel {get;set;}
		public int id {get;set;}
		public int since {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextlevel",prefix),contextlevel));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("since",prefix),since.ToString()));
			return keyValuePairs;
		}

	}
}
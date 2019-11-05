using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Fieldnotification : IModel 
	{

		public string fieldname {get;set;}
		public string notification {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fieldname",prefix),fieldname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("notification",prefix),notification));
			return keyValuePairs;
		}

	}
}
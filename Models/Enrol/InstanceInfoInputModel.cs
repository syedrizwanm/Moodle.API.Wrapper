using System.Collections.Generic;

namespace Moodle.Api.Models.Enrol
{
	public sealed class InstanceInfoInputModel : IModel 
	{
		public int instanceid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instanceid",prefix),instanceid.ToString()));
			return keyValuePairs;
		}

	}
}
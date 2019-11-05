using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class RemoveUserDeviceInputModel : IModel 
	{
		public string appid {get;set;}
		public string uuid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("appid",prefix),appid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("uuid",prefix),uuid));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserDeviceInputModel : IModel 
	{
		public string appid {get;set;}
		public string model {get;set;}
		public string name {get;set;}
		public string platform {get;set;}
		public string pushid {get;set;}
		public string uuid {get;set;}
		public string version {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("appid",prefix),appid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("model",prefix),model));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("platform",prefix),platform));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pushid",prefix),pushid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("uuid",prefix),uuid));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("version",prefix),version));
			return keyValuePairs;
		}

	}
}
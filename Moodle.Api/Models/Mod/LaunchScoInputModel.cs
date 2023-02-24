using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class LaunchScoInputModel : IModel 
	{
		public int scoid {get;set;}
		public int scormid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scoid",prefix),scoid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scormid",prefix),scormid.ToString()));
			return keyValuePairs;
		}

	}
}
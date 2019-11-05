using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Statuse : IModel 
	{

		public int cmid {get;set;}
		public int instance {get;set;}
		public string modname {get;set;}
		public int state {get;set;}
		public int timecompleted {get;set;}
		public int tracking {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cmid",prefix),cmid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instance",prefix),instance.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("modname",prefix),modname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("state",prefix),state.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecompleted",prefix),timecompleted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("tracking",prefix),tracking.ToString()));
			return keyValuePairs;
		}

	}
}
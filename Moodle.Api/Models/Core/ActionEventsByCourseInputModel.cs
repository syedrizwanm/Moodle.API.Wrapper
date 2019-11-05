using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ActionEventsByCourseInputModel : IModel 
	{
		public int aftereventid {get;set;}
		public int courseid {get;set;}
		public int limitnum {get;set;}
		public int timesortfrom {get;set;}
		public int timesortto {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("aftereventid",prefix),aftereventid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitnum",prefix),limitnum.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timesortfrom",prefix),timesortfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timesortto",prefix),timesortto.ToString()));
			return keyValuePairs;
		}

	}
}
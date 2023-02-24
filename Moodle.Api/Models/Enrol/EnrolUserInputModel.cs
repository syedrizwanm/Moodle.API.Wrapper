using System.Collections.Generic;

namespace Moodle.Api.Models.Enrol
{
	public sealed class EnrolUserInputModel : IModel 
	{
		public int courseid {get;set;}
		public int instanceid {get;set;}
		public string password {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instanceid",prefix),instanceid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("password",prefix),password));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CourseEnrolmentMethodsModel : IModel 
	{
		public int courseid {get;set;}
		public int id {get;set;}
		public string name {get;set;}
		public string status {get;set;}
		public string type {get;set;}
		public string wsfunction {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("wsfunction",prefix),wsfunction));
			return keyValuePairs;
		}

	}
}
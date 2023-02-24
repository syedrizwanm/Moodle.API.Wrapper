using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Sitenote : IModel 
	{

		public string content {get;set;}
		public int courseid {get;set;}
		public int created {get;set;}
		public int format {get;set;}
		public int id {get;set;}
		public int lastmodified {get;set;}
		public string publishstate {get;set;}
		public int userid {get;set;}
		public int usermodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content",prefix),content));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("created",prefix),created.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("format",prefix),format.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastmodified",prefix),lastmodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("publishstate",prefix),publishstate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			return keyValuePairs;
		}

	}
}
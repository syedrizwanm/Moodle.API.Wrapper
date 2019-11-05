using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Timer : IModel 
	{

		public int completed {get;set;}
		public int id {get;set;}
		public int lessonid {get;set;}
		public int lessontime {get;set;}
		public int starttime {get;set;}
		public int timemodifiedoffline {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completed",prefix),completed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lessonid",prefix),lessonid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lessontime",prefix),lessontime.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("starttime",prefix),starttime.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodifiedoffline",prefix),timemodifiedoffline.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
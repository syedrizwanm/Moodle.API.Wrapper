using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Completion : IModel 
	{

		public int complete {get;set;}
		public Detail details {get;set;}
		public string status {get;set;}
		public int timecompleted {get;set;}
		public string title {get;set;}
		public int type {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("complete",prefix),complete.ToString()));
			var detailsItems = details.ToKeyValuePairs("details");
			keyValuePairs.AddRange(detailsItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecompleted",prefix),timecompleted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("title",prefix),title));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type.ToString()));
			return keyValuePairs;
		}

	}
}
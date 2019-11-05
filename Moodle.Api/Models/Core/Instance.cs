using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Instance : IModel 
	{

		public string feedback {get;set;}
		public int feedbackformat {get;set;}
		public Guide guide {get;set;}
		public int id {get;set;}
		public int itemid {get;set;}
		public int raterid {get;set;}
		public string rawgrade {get;set;}
		public Rubric rubric {get;set;}
		public int status {get;set;}
		public int timemodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedback",prefix),feedback));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedbackformat",prefix),feedbackformat.ToString()));
			var guideItems = guide.ToKeyValuePairs("guide");
			keyValuePairs.AddRange(guideItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("raterid",prefix),raterid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rawgrade",prefix),rawgrade));
			var rubricItems = rubric.ToKeyValuePairs("rubric");
			keyValuePairs.AddRange(rubricItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Anonattempt : IModel 
	{

		public int courseid {get;set;}
		public int id {get;set;}
		public int number {get;set;}
		public List<Response> responses {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("number",prefix),number.ToString()));

			for(var responsesIndex = 0; responsesIndex<responses.Count;responsesIndex++) 
			{
				var responsesItem = responses[responsesIndex];
				var responsesItems = responsesItem.ToKeyValuePairs("responses[" + responsesIndex + "]");
				keyValuePairs.AddRange(responsesItems);
			}

			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Option : IModel 
	{

		public int id {get;set;}
		public int maxanswer {get;set;}
		public int numberofuser {get;set;}
		public double percentageamount {get;set;}
		public string text {get;set;}
		public List<Userresponse> userresponses {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxanswer",prefix),maxanswer.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("numberofuser",prefix),numberofuser.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("percentageamount",prefix),percentageamount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));

			for(var userresponsesIndex = 0; userresponsesIndex<userresponses.Count;userresponsesIndex++) 
			{
				var userresponsesItem = userresponses[userresponsesIndex];
				var userresponsesItems = userresponsesItem.ToKeyValuePairs("userresponses[" + userresponsesIndex + "]");
				keyValuePairs.AddRange(userresponsesItems);
			}

			return keyValuePairs;
		}

	}
}
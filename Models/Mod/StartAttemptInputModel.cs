using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class StartAttemptInputModel : IModel 
	{
		public int forcenew {get;set;}
		public List<PreflightdataInputModel> preflightdata {get;set;}
		public int quizid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("forcenew",prefix),forcenew.ToString()));

			for(var preflightdataIndex = 0; preflightdataIndex<preflightdata.Count;preflightdataIndex++) 
			{
				var preflightdataItem = preflightdata[preflightdataIndex];
				var preflightdataItems = preflightdataItem.ToKeyValuePairs("preflightdata[" + preflightdataIndex + "]");
				keyValuePairs.AddRange(preflightdataItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("quizid",prefix),quizid.ToString()));
			return keyValuePairs;
		}

	}
}
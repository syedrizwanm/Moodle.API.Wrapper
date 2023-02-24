using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AttemptDataInputModel : IModel 
	{
		public int attemptid {get;set;}
		public int page {get;set;}
		public List<PreflightdataInputModel> preflightdata {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attemptid",prefix),attemptid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("page",prefix),page.ToString()));

			for(var preflightdataIndex = 0; preflightdataIndex<preflightdata.Count;preflightdataIndex++) 
			{
				var preflightdataItem = preflightdata[preflightdataIndex];
				var preflightdataItems = preflightdataItem.ToKeyValuePairs("preflightdata[" + preflightdataIndex + "]");
				keyValuePairs.AddRange(preflightdataItems);
			}

			return keyValuePairs;
		}

	}
}
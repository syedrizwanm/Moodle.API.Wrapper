using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ProcessAttemptInputModel : IModel 
	{
		public int attemptid {get;set;}
		public List<DatumInputModel> data {get;set;}
		public int finishattempt {get;set;}
		public List<PreflightdataInputModel> preflightdata {get;set;}
		public int timeup {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attemptid",prefix),attemptid.ToString()));

			for(var dataIndex = 0; dataIndex<data.Count;dataIndex++) 
			{
				var dataItem = data[dataIndex];
				var dataItems = dataItem.ToKeyValuePairs("data[" + dataIndex + "]");
				keyValuePairs.AddRange(dataItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("finishattempt",prefix),finishattempt.ToString()));

			for(var preflightdataIndex = 0; preflightdataIndex<preflightdata.Count;preflightdataIndex++) 
			{
				var preflightdataItem = preflightdata[preflightdataIndex];
				var preflightdataItems = preflightdataItem.ToKeyValuePairs("preflightdata[" + preflightdataIndex + "]");
				keyValuePairs.AddRange(preflightdataItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeup",prefix),timeup.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class SaveAttemptInputModel : IModel 
	{
		public int attemptid {get;set;}
		public List<DatumInputModel> data {get;set;}
		public List<PreflightdataInputModel> preflightdata {get;set;}


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
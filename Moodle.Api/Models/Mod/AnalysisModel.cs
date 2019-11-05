using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AnalysisModel : IModel 
	{
		public int completedcount {get;set;}
		public int itemscount {get;set;}
		public List<Itemsdata> itemsdata {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completedcount",prefix),completedcount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemscount",prefix),itemscount.ToString()));

			for(var itemsdataIndex = 0; itemsdataIndex<itemsdata.Count;itemsdataIndex++) 
			{
				var itemsdataItem = itemsdata[itemsdataIndex];
				var itemsdataItems = itemsdataItem.ToKeyValuePairs("itemsdata[" + itemsdataIndex + "]");
				keyValuePairs.AddRange(itemsdataItems);
			}


			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}
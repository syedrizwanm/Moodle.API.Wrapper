using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AttemptAccessInformationModel : IModel 
	{
		public int endtime {get;set;}
		public int isfinished {get;set;}
		public int ispreflightcheckrequired {get;set;}
		public List<string> preventnewattemptreasons {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("endtime",prefix),endtime.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isfinished",prefix),isfinished.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ispreflightcheckrequired",prefix),ispreflightcheckrequired.ToString()));

			for(var preventnewattemptreasonsIndex = 0; preventnewattemptreasonsIndex<preventnewattemptreasons.Count;preventnewattemptreasonsIndex++) 
			{
				var preventnewattemptreasonsItem = preventnewattemptreasons[preventnewattemptreasonsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("preventnewattemptreasons[" + preventnewattemptreasonsIndex + "]",prefix), preventnewattemptreasonsItem));
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
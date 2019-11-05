using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class DataAccessInformationModel : IModel 
	{
		public int canaddentry {get;set;}
		public int canapprove {get;set;}
		public int canmanageentries {get;set;}
		public int entrieslefttoadd {get;set;}
		public int entrieslefttoview {get;set;}
		public int groupid {get;set;}
		public int inreadonlyperiod {get;set;}
		public int numentries {get;set;}
		public int timeavailable {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canaddentry",prefix),canaddentry.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canapprove",prefix),canapprove.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanageentries",prefix),canmanageentries.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("entrieslefttoadd",prefix),entrieslefttoadd.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("entrieslefttoview",prefix),entrieslefttoview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("inreadonlyperiod",prefix),inreadonlyperiod.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("numentries",prefix),numentries.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timeavailable",prefix),timeavailable.ToString()));

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
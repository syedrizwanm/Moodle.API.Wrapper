using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class LessonAccessInformationModel : IModel 
	{
		public int attemptscount {get;set;}
		public int cangrade {get;set;}
		public int canmanage {get;set;}
		public int canviewreports {get;set;}
		public int firstpageid {get;set;}
		public int lastpageseen {get;set;}
		public int leftduringtimedsession {get;set;}
		public List<Preventaccessreason> preventaccessreasons {get;set;}
		public int reviewmode {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attemptscount",prefix),attemptscount.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cangrade",prefix),cangrade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanage",prefix),canmanage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canviewreports",prefix),canviewreports.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("firstpageid",prefix),firstpageid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastpageseen",prefix),lastpageseen.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("leftduringtimedsession",prefix),leftduringtimedsession.ToString()));

			for(var preventaccessreasonsIndex = 0; preventaccessreasonsIndex<preventaccessreasons.Count;preventaccessreasonsIndex++) 
			{
				var preventaccessreasonsItem = preventaccessreasons[preventaccessreasonsIndex];
				var preventaccessreasonsItems = preventaccessreasonsItem.ToKeyValuePairs("preventaccessreasons[" + preventaccessreasonsIndex + "]");
				keyValuePairs.AddRange(preventaccessreasonsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewmode",prefix),reviewmode.ToString()));

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
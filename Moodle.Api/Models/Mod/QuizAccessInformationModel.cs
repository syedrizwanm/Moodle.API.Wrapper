using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class QuizAccessInformationModel : IModel 
	{
		public List<string> accessrules {get;set;}
		public List<string> activerulenames {get;set;}
		public int canattempt {get;set;}
		public int canmanage {get;set;}
		public int canpreview {get;set;}
		public int canreviewmyattempts {get;set;}
		public int canviewreports {get;set;}
		public List<string> preventaccessreasons {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var accessrulesIndex = 0; accessrulesIndex<accessrules.Count;accessrulesIndex++) 
			{
				var accessrulesItem = accessrules[accessrulesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("accessrules[" + accessrulesIndex + "]",prefix), accessrulesItem));
			}


			for(var activerulenamesIndex = 0; activerulenamesIndex<activerulenames.Count;activerulenamesIndex++) 
			{
				var activerulenamesItem = activerulenames[activerulenamesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("activerulenames[" + activerulenamesIndex + "]",prefix), activerulenamesItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canattempt",prefix),canattempt.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanage",prefix),canmanage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canpreview",prefix),canpreview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canreviewmyattempts",prefix),canreviewmyattempts.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canviewreports",prefix),canviewreports.ToString()));

			for(var preventaccessreasonsIndex = 0; preventaccessreasonsIndex<preventaccessreasons.Count;preventaccessreasonsIndex++) 
			{
				var preventaccessreasonsItem = preventaccessreasons[preventaccessreasonsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("preventaccessreasons[" + preventaccessreasonsIndex + "]",prefix), preventaccessreasonsItem));
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
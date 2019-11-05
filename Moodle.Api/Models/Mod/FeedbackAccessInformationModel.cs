using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class FeedbackAccessInformationModel : IModel 
	{
		public int cancomplete {get;set;}
		public int candeletesubmissions {get;set;}
		public int canedititems {get;set;}
		public int cansubmit {get;set;}
		public int canviewanalysis {get;set;}
		public int canviewreports {get;set;}
		public int isalreadysubmitted {get;set;}
		public int isanonymous {get;set;}
		public int isempty {get;set;}
		public int isopen {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cancomplete",prefix),cancomplete.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("candeletesubmissions",prefix),candeletesubmissions.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canedititems",prefix),canedititems.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cansubmit",prefix),cansubmit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canviewanalysis",prefix),canviewanalysis.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canviewreports",prefix),canviewreports.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isalreadysubmitted",prefix),isalreadysubmitted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isanonymous",prefix),isanonymous.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isempty",prefix),isempty.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isopen",prefix),isopen.ToString()));

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
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubmitForGradingInputModel : IModel 
	{
		public int acceptsubmissionstatement {get;set;}
		public int assignmentid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("acceptsubmissionstatement",prefix),acceptsubmissionstatement.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignmentid",prefix),assignmentid.ToString()));
			return keyValuePairs;
		}

	}
}
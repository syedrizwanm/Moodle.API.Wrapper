using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubmitGradingFormInputModel : IModel 
	{
		public int assignmentid {get;set;}
		public string jsonformdata {get;set;}
		public int userid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignmentid",prefix),assignmentid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("jsonformdata",prefix),jsonformdata));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
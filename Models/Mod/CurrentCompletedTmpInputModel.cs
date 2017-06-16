using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class CurrentCompletedTmpInputModel : IModel 
	{
		public int feedbackid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedbackid",prefix),feedbackid.ToString()));
			return keyValuePairs;
		}

	}
}
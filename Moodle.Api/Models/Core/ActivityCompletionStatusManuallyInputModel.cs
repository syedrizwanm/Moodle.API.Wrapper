using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ActivityCompletionStatusManuallyInputModel : IModel 
	{
		public int cmid {get;set;}
		public int completed {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cmid",prefix),cmid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completed",prefix),completed.ToString()));
			return keyValuePairs;
		}

	}
}
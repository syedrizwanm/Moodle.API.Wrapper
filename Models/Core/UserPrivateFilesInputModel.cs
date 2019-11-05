using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserPrivateFilesInputModel : IModel 
	{
		public int draftid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("draftid",prefix),draftid.ToString()));
			return keyValuePairs;
		}

	}
}
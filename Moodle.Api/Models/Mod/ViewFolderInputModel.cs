using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewFolderInputModel : IModel 
	{
		public int folderid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("folderid",prefix),folderid.ToString()));
			return keyValuePairs;
		}

	}
}
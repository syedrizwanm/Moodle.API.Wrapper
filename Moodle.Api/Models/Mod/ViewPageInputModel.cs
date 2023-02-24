using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewPageInputModel : IModel 
	{
		public int pageid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pageid",prefix),pageid.ToString()));
			return keyValuePairs;
		}

	}
}
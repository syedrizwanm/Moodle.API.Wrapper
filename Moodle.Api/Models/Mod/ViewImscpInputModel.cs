using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewImscpInputModel : IModel 
	{
		public int imscpid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("imscpid",prefix),imscpid.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewResourceInputModel : IModel 
	{
		public int resourceid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("resourceid",prefix),resourceid.ToString()));
			return keyValuePairs;
		}

	}
}
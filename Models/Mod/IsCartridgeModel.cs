using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class IsCartridgeModel : IModel 
	{
		public int iscartridge {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iscartridge",prefix),iscartridge.ToString()));
			return keyValuePairs;
		}

	}
}
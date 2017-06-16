using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class ScaleValuesInputModel : IModel 
	{
		public int scaleid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleid",prefix),scaleid.ToString()));
			return keyValuePairs;
		}

	}
}
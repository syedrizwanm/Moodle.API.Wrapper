using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ProcessPage : IModel 
	{


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			return keyValuePairs;
		}

	}
}
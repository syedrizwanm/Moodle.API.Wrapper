using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AddEntryInputModel : IModel 
	{


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			return keyValuePairs;
		}

	}
}
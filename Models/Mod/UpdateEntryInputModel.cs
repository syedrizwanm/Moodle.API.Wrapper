using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class UpdateEntryInputModel : IModel 
	{


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			return keyValuePairs;
		}

	}
}
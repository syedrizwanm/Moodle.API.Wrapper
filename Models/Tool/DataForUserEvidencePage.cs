using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Tool
{
	public sealed class DataForUserEvidencePage : IModel 
	{


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			return keyValuePairs;
		}

	}
}
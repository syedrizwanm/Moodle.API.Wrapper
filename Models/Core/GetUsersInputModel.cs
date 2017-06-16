using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class GetUsersInputModel : IModel 
	{


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			return keyValuePairs;
		}

	}
}
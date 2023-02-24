using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class TimestampInputModel : IModel 
	{

		public string format {get;set;}
		public int timestamp {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("format",prefix),format));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timestamp",prefix),timestamp.ToString()));
			return keyValuePairs;
		}

	}
}
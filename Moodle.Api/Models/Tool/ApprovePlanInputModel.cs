using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class ApprovePlanInputModel : IModel 
	{
		public int id {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			return keyValuePairs;
		}

	}
}
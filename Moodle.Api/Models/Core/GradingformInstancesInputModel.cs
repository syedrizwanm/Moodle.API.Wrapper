using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class GradingformInstancesInputModel : IModel 
	{
		public int definitionid {get;set;}
		public int since {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("definitionid",prefix),definitionid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("since",prefix),since.ToString()));
			return keyValuePairs;
		}

	}
}
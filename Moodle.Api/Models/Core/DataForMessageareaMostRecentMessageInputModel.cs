using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DataForMessageareaMostRecentMessageInputModel : IModel 
	{
		public int currentuserid {get;set;}
		public int otheruserid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("currentuserid",prefix),currentuserid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("otheruserid",prefix),otheruserid.ToString()));
			return keyValuePairs;
		}

	}
}
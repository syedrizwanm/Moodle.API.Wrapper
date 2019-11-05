using System.Collections.Generic;

namespace Moodle.Api.Models.Message
{
	public sealed class DeleteUsersInputModel : IModel 
	{
		public List<int> userids {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var useridsIndex = 0; useridsIndex<userids.Count;useridsIndex++) 
			{
				var useridsItem = userids[useridsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userids[" + useridsIndex + "]",prefix), useridsItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}
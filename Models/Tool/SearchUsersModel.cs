using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class SearchUsersModel : IModel 
	{
		public int count {get;set;}
		public List<User> users {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("count",prefix),count.ToString()));

			for(var usersIndex = 0; usersIndex<users.Count;usersIndex++) 
			{
				var usersItem = users[usersIndex];
				var usersItems = usersItem.ToKeyValuePairs("users[" + usersIndex + "]");
				keyValuePairs.AddRange(usersItems);
			}

			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UsersInputModel : IModel 
	{

		public List<UserInputModel> users {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


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
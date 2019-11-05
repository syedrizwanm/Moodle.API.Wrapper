using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class BlockedUsersModel : IModel 
	{
		public List<User> users {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var usersIndex = 0; usersIndex<users.Count;usersIndex++) 
			{
				var usersItem = users[usersIndex];
				var usersItems = usersItem.ToKeyValuePairs("users[" + usersIndex + "]");
				keyValuePairs.AddRange(usersItems);
			}


			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}
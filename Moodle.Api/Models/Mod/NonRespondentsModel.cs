using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class NonRespondentsModel : IModel 
	{
		public int total {get;set;}
		public List<User> users {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("total",prefix),total.ToString()));

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
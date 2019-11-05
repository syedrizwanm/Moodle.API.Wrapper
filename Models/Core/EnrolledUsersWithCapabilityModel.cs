using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class EnrolledUsersWithCapabilityModel : IModel 
	{
		public string capability {get;set;}
		public int courseid {get;set;}
		public List<User> users {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("capability",prefix),capability));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));

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
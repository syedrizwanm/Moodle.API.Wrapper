using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class CourseUserProfilesInputModel : IModel 
	{
		public List<UserlistInputModel> userlist {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var userlistIndex = 0; userlistIndex<userlist.Count;userlistIndex++) 
			{
				var userlistItem = userlist[userlistIndex];
				var userlistItems = userlistItem.ToKeyValuePairs("userlist[" + userlistIndex + "]");
				keyValuePairs.AddRange(userlistItems);
			}

			return keyValuePairs;
		}

	}
}
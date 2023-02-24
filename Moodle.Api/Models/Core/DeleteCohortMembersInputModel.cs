using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DeleteCohortMembersInputModel : IModel 
	{
		public List<MemberInputModel> members {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var membersIndex = 0; membersIndex<members.Count;membersIndex++) 
			{
				var membersItem = members[membersIndex];
				var membersItems = membersItem.ToKeyValuePairs("members[" + membersIndex + "]");
				keyValuePairs.AddRange(membersItems);
			}

			return keyValuePairs;
		}

	}
}
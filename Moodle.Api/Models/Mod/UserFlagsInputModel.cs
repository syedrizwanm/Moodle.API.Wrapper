using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class UserFlagsInputModel : IModel 
	{
		public List<int> assignmentids {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var assignmentidsIndex = 0; assignmentidsIndex<assignmentids.Count;assignmentidsIndex++) 
			{
				var assignmentidsItem = assignmentids[assignmentidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignmentids[" + assignmentidsIndex + "]",prefix), assignmentidsItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}
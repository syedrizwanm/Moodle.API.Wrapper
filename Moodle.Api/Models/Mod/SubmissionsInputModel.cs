using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubmissionsInputModel : IModel 
	{
		public List<int> assignmentids {get;set;}
		public int before {get;set;}
		public int since {get;set;}
		public string status {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var assignmentidsIndex = 0; assignmentidsIndex<assignmentids.Count;assignmentidsIndex++) 
			{
				var assignmentidsItem = assignmentids[assignmentidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignmentids[" + assignmentidsIndex + "]",prefix), assignmentidsItem.ToString()));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("before",prefix),before.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("since",prefix),since.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status));
			return keyValuePairs;
		}

	}
}
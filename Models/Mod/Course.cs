using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Course : IModel 
	{

		public List<Assignment> assignments {get;set;}
		public string fullname {get;set;}
		public int id {get;set;}
		public string shortname {get;set;}
		public int timemodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var assignmentsIndex = 0; assignmentsIndex<assignments.Count;assignmentsIndex++) 
			{
				var assignmentsItem = assignments[assignmentsIndex];
				var assignmentsItems = assignmentsItem.ToKeyValuePairs("assignments[" + assignmentsIndex + "]");
				keyValuePairs.AddRange(assignmentsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			return keyValuePairs;
		}

	}
}
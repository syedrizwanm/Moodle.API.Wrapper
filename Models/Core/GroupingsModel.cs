using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class GroupingsModel : IModel 
	{

		public int courseid {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public List<Group> groups {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public string name {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));

			for(var groupsIndex = 0; groupsIndex<groups.Count;groupsIndex++) 
			{
				var groupsItem = groups[groupsIndex];
				var groupsItems = groupsItem.ToKeyValuePairs("groups[" + groupsIndex + "]");
				keyValuePairs.AddRange(groupsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			return keyValuePairs;
		}

	}
}
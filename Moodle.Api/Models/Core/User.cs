using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class User : IModel 
	{

		public string address {get;set;}
		public string aim {get;set;}
		public string city {get;set;}
		public string country {get;set;}
		public List<Customfield> customfields {get;set;}
		public string department {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public string email {get;set;}
		public List<Enrolledcourse> enrolledcourses {get;set;}
		public int firstaccess {get;set;}
		public string firstname {get;set;}
		public string fullname {get;set;}
		public List<Group> groups {get;set;}
		public string icq {get;set;}
		public int id {get;set;}
		public string institution {get;set;}
		public string interests {get;set;}
		public int lastaccess {get;set;}
		public string lastname {get;set;}
		public string msn {get;set;}
		public string phone1 {get;set;}
		public string phone2 {get;set;}
		public List<Preference> preferences {get;set;}
		public string profileimageurl {get;set;}
		public string profileimageurlsmall {get;set;}
		public List<Role> roles {get;set;}
		public string skype {get;set;}
		public string url {get;set;}
		public string username {get;set;}
		public string yahoo {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("address",prefix),address));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("aim",prefix),aim));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("city",prefix),city));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("country",prefix),country));

			for(var customfieldsIndex = 0; customfieldsIndex<customfields.Count;customfieldsIndex++) 
			{
				var customfieldsItem = customfields[customfieldsIndex];
				var customfieldsItems = customfieldsItem.ToKeyValuePairs("customfields[" + customfieldsIndex + "]");
				keyValuePairs.AddRange(customfieldsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("department",prefix),department));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("email",prefix),email));

			for(var enrolledcoursesIndex = 0; enrolledcoursesIndex<enrolledcourses.Count;enrolledcoursesIndex++) 
			{
				var enrolledcoursesItem = enrolledcourses[enrolledcoursesIndex];
				var enrolledcoursesItems = enrolledcoursesItem.ToKeyValuePairs("enrolledcourses[" + enrolledcoursesIndex + "]");
				keyValuePairs.AddRange(enrolledcoursesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("firstaccess",prefix),firstaccess.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("firstname",prefix),firstname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));

			for(var groupsIndex = 0; groupsIndex<groups.Count;groupsIndex++) 
			{
				var groupsItem = groups[groupsIndex];
				var groupsItems = groupsItem.ToKeyValuePairs("groups[" + groupsIndex + "]");
				keyValuePairs.AddRange(groupsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("icq",prefix),icq));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("institution",prefix),institution));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("interests",prefix),interests));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastaccess",prefix),lastaccess.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastname",prefix),lastname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("msn",prefix),msn));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("phone1",prefix),phone1));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("phone2",prefix),phone2));

			for(var preferencesIndex = 0; preferencesIndex<preferences.Count;preferencesIndex++) 
			{
				var preferencesItem = preferences[preferencesIndex];
				var preferencesItems = preferencesItem.ToKeyValuePairs("preferences[" + preferencesIndex + "]");
				keyValuePairs.AddRange(preferencesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurl",prefix),profileimageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurlsmall",prefix),profileimageurlsmall));

			for(var rolesIndex = 0; rolesIndex<roles.Count;rolesIndex++) 
			{
				var rolesItem = roles[rolesIndex];
				var rolesItems = rolesItem.ToKeyValuePairs("roles[" + rolesIndex + "]");
				keyValuePairs.AddRange(rolesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("skype",prefix),skype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("username",prefix),username));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("yahoo",prefix),yahoo));
			return keyValuePairs;
		}

	}
}
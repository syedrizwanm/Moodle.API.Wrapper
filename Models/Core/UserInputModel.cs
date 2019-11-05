using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserInputModel : IModel 
	{

		public string alternatename {get;set;}
		public string auth {get;set;}
		public string calendartype {get;set;}
		public string city {get;set;}
		public string country {get;set;}
		public List<CustomfieldInputModel> customfields {get;set;}
		public string description {get;set;}
		public string email {get;set;}
		public string firstname {get;set;}
		public string firstnamephonetic {get;set;}
		public int id {get;set;}
		public string idnumber {get;set;}
		public string lang {get;set;}
		public string lastname {get;set;}
		public string lastnamephonetic {get;set;}
		public int mailformat {get;set;}
		public string middlename {get;set;}
		public string password {get;set;}
		public List<PreferenceInputModel> preferences {get;set;}
		public int suspended {get;set;}
		public string theme {get;set;}
		public string timezone {get;set;}
		public string username {get;set;}
		public int userpicture {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("alternatename",prefix),alternatename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("auth",prefix),auth));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("calendartype",prefix),calendartype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("city",prefix),city));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("country",prefix),country));

			for(var customfieldsIndex = 0; customfieldsIndex<customfields.Count;customfieldsIndex++) 
			{
				var customfieldsItem = customfields[customfieldsIndex];
				var customfieldsItems = customfieldsItem.ToKeyValuePairs("customfields[" + customfieldsIndex + "]");
				keyValuePairs.AddRange(customfieldsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("email",prefix),email));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("firstname",prefix),firstname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("firstnamephonetic",prefix),firstnamephonetic));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("idnumber",prefix),idnumber));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lang",prefix),lang));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastname",prefix),lastname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastnamephonetic",prefix),lastnamephonetic));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mailformat",prefix),mailformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("middlename",prefix),middlename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("password",prefix),password));

			for(var preferencesIndex = 0; preferencesIndex<preferences.Count;preferencesIndex++) 
			{
				var preferencesItem = preferences[preferencesIndex];
				var preferencesItems = preferencesItem.ToKeyValuePairs("preferences[" + preferencesIndex + "]");
				keyValuePairs.AddRange(preferencesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("suspended",prefix),suspended.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("theme",prefix),theme));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timezone",prefix),timezone));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("username",prefix),username));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userpicture",prefix),userpicture.ToString()));
			return keyValuePairs;
		}

	}
}
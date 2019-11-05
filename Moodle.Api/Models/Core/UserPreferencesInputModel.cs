using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserPreferencesInputModel : IModel 
	{

		public int emailstop {get;set;}
		public List<PreferenceInputModel> preferences {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("emailstop",prefix),emailstop.ToString()));

			for(var preferencesIndex = 0; preferencesIndex<preferences.Count;preferencesIndex++) 
			{
				var preferencesItem = preferences[preferencesIndex];
				var preferencesItems = preferencesItem.ToKeyValuePairs("preferences[" + preferencesIndex + "]");
				keyValuePairs.AddRange(preferencesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Auth
{
	public sealed class SignupSettingsModel : IModel 
	{
		public string country {get;set;}
		public string defaultcity {get;set;}
		public List<string> namefields {get;set;}
		public string passwordpolicy {get;set;}
		public List<Profilefield> profilefields {get;set;}
		public string recaptchachallengehash {get;set;}
		public string recaptchachallengeimage {get;set;}
		public string recaptchachallengejs {get;set;}
		public string recaptchapublickey {get;set;}
		public string sitepolicy {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("country",prefix),country));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("defaultcity",prefix),defaultcity));

			for(var namefieldsIndex = 0; namefieldsIndex<namefields.Count;namefieldsIndex++) 
			{
				var namefieldsItem = namefields[namefieldsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("namefields[" + namefieldsIndex + "]",prefix), namefieldsItem));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("passwordpolicy",prefix),passwordpolicy));

			for(var profilefieldsIndex = 0; profilefieldsIndex<profilefields.Count;profilefieldsIndex++) 
			{
				var profilefieldsItem = profilefields[profilefieldsIndex];
				var profilefieldsItems = profilefieldsItem.ToKeyValuePairs("profilefields[" + profilefieldsIndex + "]");
				keyValuePairs.AddRange(profilefieldsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("recaptchachallengehash",prefix),recaptchachallengehash));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("recaptchachallengeimage",prefix),recaptchachallengeimage));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("recaptchachallengejs",prefix),recaptchachallengejs));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("recaptchapublickey",prefix),recaptchapublickey));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sitepolicy",prefix),sitepolicy));

			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}
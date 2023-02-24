using System.Collections.Generic;

namespace Moodle.Api.Models.Auth
{
	public sealed class SignupUserInputModel : IModel 
	{
		public string city {get;set;}
		public string country {get;set;}
		public List<CustomprofilefieldInputModel> customprofilefields {get;set;}
		public string email {get;set;}
		public string firstname {get;set;}
		public string lastname {get;set;}
		public string password {get;set;}
		public string recaptchachallengehash {get;set;}
		public string recaptcharesponse {get;set;}
		public string redirect {get;set;}
		public string username {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("city",prefix),city));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("country",prefix),country));

			for(var customprofilefieldsIndex = 0; customprofilefieldsIndex<customprofilefields.Count;customprofilefieldsIndex++) 
			{
				var customprofilefieldsItem = customprofilefields[customprofilefieldsIndex];
				var customprofilefieldsItems = customprofilefieldsItem.ToKeyValuePairs("customprofilefields[" + customprofilefieldsIndex + "]");
				keyValuePairs.AddRange(customprofilefieldsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("email",prefix),email));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("firstname",prefix),firstname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lastname",prefix),lastname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("password",prefix),password));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("recaptchachallengehash",prefix),recaptchachallengehash));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("recaptcharesponse",prefix),recaptcharesponse));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("redirect",prefix),redirect));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("username",prefix),username));
			return keyValuePairs;
		}

	}
}
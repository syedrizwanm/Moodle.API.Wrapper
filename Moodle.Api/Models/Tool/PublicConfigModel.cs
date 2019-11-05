using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class PublicConfigModel : IModel 
	{
		public string authinstructions {get;set;}
		public int authloginviaemail {get;set;}
		public int authnoneenabled {get;set;}
		public string compactlogourl {get;set;}
		public int enablemobilewebservice {get;set;}
		public int enablewebservices {get;set;}
		public string forgottenpasswordurl {get;set;}
		public int guestlogin {get;set;}
		public string httpswwwroot {get;set;}
		public List<Identityprovider> identityproviders {get;set;}
		public string launchurl {get;set;}
		public string logourl {get;set;}
		public int maintenanceenabled {get;set;}
		public string maintenancemessage {get;set;}
		public string mobilecssurl {get;set;}
		public string registerauth {get;set;}
		public int rememberusername {get;set;}
		public string sitename {get;set;}
		public string tool_mobile_disabledfeatures {get;set;}
		public int typeoflogin {get;set;}
		public List<Warning> warnings {get;set;}
		public string wwwroot {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("authinstructions",prefix),authinstructions));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("authloginviaemail",prefix),authloginviaemail.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("authnoneenabled",prefix),authnoneenabled.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("compactlogourl",prefix),compactlogourl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enablemobilewebservice",prefix),enablemobilewebservice.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("enablewebservices",prefix),enablewebservices.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("forgottenpasswordurl",prefix),forgottenpasswordurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("guestlogin",prefix),guestlogin.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("httpswwwroot",prefix),httpswwwroot));

			for(var identityprovidersIndex = 0; identityprovidersIndex<identityproviders.Count;identityprovidersIndex++) 
			{
				var identityprovidersItem = identityproviders[identityprovidersIndex];
				var identityprovidersItems = identityprovidersItem.ToKeyValuePairs("identityproviders[" + identityprovidersIndex + "]");
				keyValuePairs.AddRange(identityprovidersItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("launchurl",prefix),launchurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("logourl",prefix),logourl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maintenanceenabled",prefix),maintenanceenabled.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maintenancemessage",prefix),maintenancemessage));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mobilecssurl",prefix),mobilecssurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("registerauth",prefix),registerauth));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rememberusername",prefix),rememberusername.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sitename",prefix),sitename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("tool_mobile_disabledfeatures",prefix),tool_mobile_disabledfeatures));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("typeoflogin",prefix),typeoflogin.ToString()));

			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("wwwroot",prefix),wwwroot));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ToolProxyRegistrationRequestModel : IModel 
	{
		public string launch_presentation_return_url {get;set;}
		public string lti_message_type {get;set;}
		public string lti_version {get;set;}
		public string reg_key {get;set;}
		public string reg_password {get;set;}
		public string reg_url {get;set;}
		public string tc_profile_url {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("launch_presentation_return_url",prefix),launch_presentation_return_url));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lti_message_type",prefix),lti_message_type));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lti_version",prefix),lti_version));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reg_key",prefix),reg_key));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reg_password",prefix),reg_password));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reg_url",prefix),reg_url));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("tc_profile_url",prefix),tc_profile_url));
			return keyValuePairs;
		}

	}
}
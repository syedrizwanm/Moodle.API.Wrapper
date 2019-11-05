using System.Collections.Generic;

namespace Moodle.Api.Models.Message
{
	public sealed class PopupNotificationsInputModel : IModel 
	{
		public int limit {get;set;}
		public int newestfirst {get;set;}
		public int offset {get;set;}
		public int useridto {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limit",prefix),limit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("newestfirst",prefix),newestfirst.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("offset",prefix),offset.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridto",prefix),useridto.ToString()));
			return keyValuePairs;
		}

	}
}
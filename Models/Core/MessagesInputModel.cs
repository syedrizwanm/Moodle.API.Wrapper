using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class MessagesInputModel : IModel 
	{
		public int limitfrom {get;set;}
		public int limitnum {get;set;}
		public int newestfirst {get;set;}
		public int read {get;set;}
		public string type {get;set;}
		public int useridfrom {get;set;}
		public int useridto {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitfrom",prefix),limitfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitnum",prefix),limitnum.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("newestfirst",prefix),newestfirst.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("read",prefix),read.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("type",prefix),type));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridfrom",prefix),useridfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("useridto",prefix),useridto.ToString()));
			return keyValuePairs;
		}

	}
}
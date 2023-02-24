using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Online : IModel 
	{

		public string fullname {get;set;}
		public int id {get;set;}
		public string profileimageurl {get;set;}
		public string profileimageurlsmall {get;set;}
		public int unread {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurl",prefix),profileimageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurlsmall",prefix),profileimageurlsmall));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("unread",prefix),unread.ToString()));
			return keyValuePairs;
		}

	}
}
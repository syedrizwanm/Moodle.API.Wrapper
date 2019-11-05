using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ForumDiscussionsPaginatedInputModel : IModel 
	{
		public int forumid {get;set;}
		public int page {get;set;}
		public int perpage {get;set;}
		public string sortby {get;set;}
		public string sortdirection {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("forumid",prefix),forumid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("page",prefix),page.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("perpage",prefix),perpage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortby",prefix),sortby));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortdirection",prefix),sortdirection));
			return keyValuePairs;
		}

	}
}
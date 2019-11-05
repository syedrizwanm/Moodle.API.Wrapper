using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ForumDiscussionPostsInputModel : IModel 
	{
		public int discussionid {get;set;}
		public string sortby {get;set;}
		public string sortdirection {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("discussionid",prefix),discussionid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortby",prefix),sortby));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortdirection",prefix),sortdirection));
			return keyValuePairs;
		}

	}
}
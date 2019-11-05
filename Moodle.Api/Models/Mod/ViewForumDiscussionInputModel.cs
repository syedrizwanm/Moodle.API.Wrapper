using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewForumDiscussionInputModel : IModel 
	{
		public int discussionid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("discussionid",prefix),discussionid.ToString()));
			return keyValuePairs;
		}

	}
}
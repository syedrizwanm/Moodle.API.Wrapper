using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class DiscussionInputModel : IModel 
	{
		public int forumid {get;set;}
		public int groupid {get;set;}
		public string message {get;set;}
		public List<OptionInputModel> options {get;set;}
		public string subject {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("forumid",prefix),forumid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("message",prefix),message));

			for(var optionsIndex = 0; optionsIndex<options.Count;optionsIndex++) 
			{
				var optionsItem = options[optionsIndex];
				var optionsItems = optionsItem.ToKeyValuePairs("options[" + optionsIndex + "]");
				keyValuePairs.AddRange(optionsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("subject",prefix),subject));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class DiscussionPostInputModel : IModel 
	{
		public string message {get;set;}
		public List<OptionInputModel> options {get;set;}
		public int postid {get;set;}
		public string subject {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("message",prefix),message));

			for(var optionsIndex = 0; optionsIndex<options.Count;optionsIndex++) 
			{
				var optionsItem = options[optionsIndex];
				var optionsItems = optionsItem.ToKeyValuePairs("options[" + optionsIndex + "]");
				keyValuePairs.AddRange(optionsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("postid",prefix),postid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("subject",prefix),subject));
			return keyValuePairs;
		}

	}
}
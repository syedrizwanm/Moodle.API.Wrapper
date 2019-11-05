using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ContentsInputModel : IModel 
	{
		public int courseid {get;set;}
		public List<OptionInputModel> options {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));

			for(var optionsIndex = 0; optionsIndex<options.Count;optionsIndex++) 
			{
				var optionsItem = options[optionsIndex];
				var optionsItems = optionsItem.ToKeyValuePairs("options[" + optionsIndex + "]");
				keyValuePairs.AddRange(optionsItems);
			}

			return keyValuePairs;
		}

	}
}
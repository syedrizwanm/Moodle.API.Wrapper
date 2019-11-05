using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ChecksInputModel : IModel 
	{
		public int courseid {get;set;}
		public List<string> filter {get;set;}
		public List<TocheckInputModel> tocheck {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));

			for(var filterIndex = 0; filterIndex<filter.Count;filterIndex++) 
			{
				var filterItem = filter[filterIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("filter[" + filterIndex + "]",prefix), filterItem));
			}


			for(var tocheckIndex = 0; tocheckIndex<tocheck.Count;tocheckIndex++) 
			{
				var tocheckItem = tocheck[tocheckIndex];
				var tocheckItems = tocheckItem.ToKeyValuePairs("tocheck[" + tocheckIndex + "]");
				keyValuePairs.AddRange(tocheckItems);
			}

			return keyValuePairs;
		}

	}
}
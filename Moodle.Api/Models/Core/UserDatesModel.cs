using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UserDatesModel : IModel 
	{
		public List<string> dates {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var datesIndex = 0; datesIndex<dates.Count;datesIndex++) 
			{
				var datesItem = dates[datesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dates[" + datesIndex + "]",prefix), datesItem));
			}

			return keyValuePairs;
		}

	}
}
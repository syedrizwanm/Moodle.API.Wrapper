using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ActionEventsByCoursesInputModel : IModel 
	{
		public List<int> courseids {get;set;}
		public int limitnum {get;set;}
		public int timesortfrom {get;set;}
		public int timesortto {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var courseidsIndex = 0; courseidsIndex<courseids.Count;courseidsIndex++) 
			{
				var courseidsItem = courseids[courseidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseids[" + courseidsIndex + "]",prefix), courseidsItem.ToString()));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitnum",prefix),limitnum.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timesortfrom",prefix),timesortfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timesortto",prefix),timesortto.ToString()));
			return keyValuePairs;
		}

	}
}
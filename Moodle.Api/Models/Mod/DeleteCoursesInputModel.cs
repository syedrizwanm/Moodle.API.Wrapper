using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class DeleteCoursesInputModel : IModel 
	{
		public List<int> courseids {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var courseidsIndex = 0; courseidsIndex<courseids.Count;courseidsIndex++) 
			{
				var courseidsItem = courseids[courseidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseids[" + courseidsIndex + "]",prefix), courseidsItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}
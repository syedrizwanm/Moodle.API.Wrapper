using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AssignmentsInputModel : IModel 
	{
		public List<string> capabilities {get;set;}
		public List<int> courseids {get;set;}
		public int includenotenrolledcourses {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var capabilitiesIndex = 0; capabilitiesIndex<capabilities.Count;capabilitiesIndex++) 
			{
				var capabilitiesItem = capabilities[capabilitiesIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("capabilities[" + capabilitiesIndex + "]",prefix), capabilitiesItem));
			}


			for(var courseidsIndex = 0; courseidsIndex<courseids.Count;courseidsIndex++) 
			{
				var courseidsItem = courseids[courseidsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseids[" + courseidsIndex + "]",prefix), courseidsItem.ToString()));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includenotenrolledcourses",prefix),includenotenrolledcourses.ToString()));
			return keyValuePairs;
		}

	}
}
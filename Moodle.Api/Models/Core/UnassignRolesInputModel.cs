using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class UnassignRolesInputModel : IModel 
	{
		public List<UnassignmentInputModel> unassignments {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var unassignmentsIndex = 0; unassignmentsIndex<unassignments.Count;unassignmentsIndex++) 
			{
				var unassignmentsItem = unassignments[unassignmentsIndex];
				var unassignmentsItems = unassignmentsItem.ToKeyValuePairs("unassignments[" + unassignmentsIndex + "]");
				keyValuePairs.AddRange(unassignmentsItems);
			}

			return keyValuePairs;
		}

	}
}
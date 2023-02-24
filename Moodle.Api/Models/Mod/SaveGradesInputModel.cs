using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SaveGradesInputModel : IModel 
	{
		public int applytoall {get;set;}
		public int assignmentid {get;set;}
		public List<GradeInputModel> grades {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("applytoall",prefix),applytoall.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignmentid",prefix),assignmentid.ToString()));

			for(var gradesIndex = 0; gradesIndex<grades.Count;gradesIndex++) 
			{
				var gradesItem = grades[gradesIndex];
				var gradesItems = gradesItem.ToKeyValuePairs("grades[" + gradesIndex + "]");
				keyValuePairs.AddRange(gradesItems);
			}

			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class GradesInputModel : IModel 
	{

		public int activityid {get;set;}
		public string component {get;set;}
		public int courseid {get;set;}
		public List<GradeInputModel> grades {get;set;}
		public ItemdetailInputModel itemdetails {get;set;}
		public int itemnumber {get;set;}
		public string source {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("activityid",prefix),activityid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));

			for(var gradesIndex = 0; gradesIndex<grades.Count;gradesIndex++) 
			{
				var gradesItem = grades[gradesIndex];
				var gradesItems = gradesItem.ToKeyValuePairs("grades[" + gradesIndex + "]");
				keyValuePairs.AddRange(gradesItems);
			}

			var itemdetailsItems = itemdetails.ToKeyValuePairs("itemdetails");
			keyValuePairs.AddRange(itemdetailsItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemnumber",prefix),itemnumber.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("source",prefix),source));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Outcome : IModel 
	{

		public string activityid {get;set;}
		public List<Grade> grades {get;set;}
		public int hidden {get;set;}
		public int itemnumber {get;set;}
		public int locked {get;set;}
		public string name {get;set;}
		public int scaleid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("activityid",prefix),activityid));

			for(var gradesIndex = 0; gradesIndex<grades.Count;gradesIndex++) 
			{
				var gradesItem = grades[gradesIndex];
				var gradesItems = gradesItem.ToKeyValuePairs("grades[" + gradesIndex + "]");
				keyValuePairs.AddRange(gradesItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hidden",prefix),hidden.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemnumber",prefix),itemnumber.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("locked",prefix),locked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleid",prefix),scaleid.ToString()));
			return keyValuePairs;
		}

	}
}
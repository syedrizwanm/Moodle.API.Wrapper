using System.Collections.Generic;

namespace Moodle.Api.Models.Gradereport
{
	public sealed class Usergrade : IModel 
	{

		public int courseid {get;set;}
		public List<Gradeitem> gradeitems {get;set;}
		public int maxdepth {get;set;}
		public string userfullname {get;set;}
		public int userid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("courseid",prefix),courseid.ToString()));

			for(var gradeitemsIndex = 0; gradeitemsIndex<gradeitems.Count;gradeitemsIndex++) 
			{
				var gradeitemsItem = gradeitems[gradeitemsIndex];
				var gradeitemsItems = gradeitemsItem.ToKeyValuePairs("gradeitems[" + gradeitemsIndex + "]");
				keyValuePairs.AddRange(gradeitemsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxdepth",prefix),maxdepth.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userfullname",prefix),userfullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			return keyValuePairs;
		}

	}
}
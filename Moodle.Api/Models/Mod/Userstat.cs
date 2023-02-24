using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Userstat : IModel 
	{

		public int completed {get;set;}
		public double grade {get;set;}
		public Gradeinfo gradeinfo {get;set;}
		public int timetotake {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("completed",prefix),completed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			var gradeinfoItems = gradeinfo.ToKeyValuePairs("gradeinfo");
			keyValuePairs.AddRange(gradeinfoItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timetotake",prefix),timetotake.ToString()));
			return keyValuePairs;
		}

	}
}
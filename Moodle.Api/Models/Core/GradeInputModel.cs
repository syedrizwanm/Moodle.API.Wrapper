using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class GradeInputModel : IModel 
	{

		public double grade {get;set;}
		public string str_feedback {get;set;}
		public int studentid {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("str_feedback",prefix),str_feedback));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("studentid",prefix),studentid.ToString()));
			return keyValuePairs;
		}

	}
}
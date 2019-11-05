using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Grade : IModel 
	{

		public int dategraded {get;set;}
		public int datesubmitted {get;set;}
		public string feedback {get;set;}
		public int feedbackformat {get;set;}
		public double grade {get;set;}
		public int hidden {get;set;}
		public int locked {get;set;}
		public int overridden {get;set;}
		public string str_feedback {get;set;}
		public string str_grade {get;set;}
		public string str_long_grade {get;set;}
		public int userid {get;set;}
		public int usermodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("dategraded",prefix),dategraded.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("datesubmitted",prefix),datesubmitted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedback",prefix),feedback));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedbackformat",prefix),feedbackformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("hidden",prefix),hidden.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("locked",prefix),locked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("overridden",prefix),overridden.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("str_feedback",prefix),str_feedback));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("str_grade",prefix),str_grade));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("str_long_grade",prefix),str_long_grade));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			return keyValuePairs;
		}

	}
}
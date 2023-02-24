using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Grade : IModel 
	{

		public int attempts {get;set;}
		public double earned {get;set;}
		public double grade {get;set;}
		public double manualpoints {get;set;}
		public int nmanual {get;set;}
		public int nquestions {get;set;}
		public double total {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("attempts",prefix),attempts.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("earned",prefix),earned.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("manualpoints",prefix),manualpoints.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("nmanual",prefix),nmanual.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("nquestions",prefix),nquestions.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("total",prefix),total.ToString()));
			return keyValuePairs;
		}

	}
}
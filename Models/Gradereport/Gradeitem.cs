using System.Collections.Generic;

namespace Moodle.Api.Models.Gradereport
{
	public sealed class Gradeitem : IModel 
	{

		public string averageformatted {get;set;}
		public int categoryid {get;set;}
		public int cmid {get;set;}
		public string feedback {get;set;}
		public int feedbackformat {get;set;}
		public int gradedategraded {get;set;}
		public int gradedatesubmitted {get;set;}
		public string gradeformatted {get;set;}
		public int gradehiddenbydate {get;set;}
		public int gradeishidden {get;set;}
		public double grademax {get;set;}
		public double grademin {get;set;}
		public int gradeneedsupdate {get;set;}
		public double graderaw {get;set;}
		public int id {get;set;}
		public int iteminstance {get;set;}
		public string itemmodule {get;set;}
		public string itemname {get;set;}
		public int itemnumber {get;set;}
		public string itemtype {get;set;}
		public string lettergradeformatted {get;set;}
		public int numusers {get;set;}
		public int outcomeid {get;set;}
		public string percentageformatted {get;set;}
		public string rangeformatted {get;set;}
		public int rank {get;set;}
		public int scaleid {get;set;}
		public string status {get;set;}
		public string weightformatted {get;set;}
		public double weightraw {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("averageformatted",prefix),averageformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("categoryid",prefix),categoryid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cmid",prefix),cmid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedback",prefix),feedback));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("feedbackformat",prefix),feedbackformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradedategraded",prefix),gradedategraded.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradedatesubmitted",prefix),gradedatesubmitted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradeformatted",prefix),gradeformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradehiddenbydate",prefix),gradehiddenbydate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradeishidden",prefix),gradeishidden.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grademax",prefix),grademax.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grademin",prefix),grademin.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradeneedsupdate",prefix),gradeneedsupdate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("graderaw",prefix),graderaw.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iteminstance",prefix),iteminstance.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemmodule",prefix),itemmodule));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemname",prefix),itemname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemnumber",prefix),itemnumber.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemtype",prefix),itemtype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lettergradeformatted",prefix),lettergradeformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("numusers",prefix),numusers.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("outcomeid",prefix),outcomeid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("percentageformatted",prefix),percentageformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rangeformatted",prefix),rangeformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rank",prefix),rank.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleid",prefix),scaleid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("weightformatted",prefix),weightformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("weightraw",prefix),weightraw.ToString()));
			return keyValuePairs;
		}

	}
}
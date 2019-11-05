using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Usercompetency : IModel 
	{

		public int canrequestreview {get;set;}
		public int canreview {get;set;}
		public int competencyid {get;set;}
		public int grade {get;set;}
		public string gradename {get;set;}
		public int id {get;set;}
		public int iscancelreviewrequestallowed {get;set;}
		public int isrequestreviewallowed {get;set;}
		public int isstartreviewallowed {get;set;}
		public int isstatusidle {get;set;}
		public int isstatusinreview {get;set;}
		public int isstatuswaitingforreview {get;set;}
		public int isstopreviewallowed {get;set;}
		public int proficiency {get;set;}
		public string proficiencyname {get;set;}
		public Reviewer reviewer {get;set;}
		public int reviewerid {get;set;}
		public int status {get;set;}
		public string statusname {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public string url {get;set;}
		public int userid {get;set;}
		public int usermodified {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canrequestreview",prefix),canrequestreview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canreview",prefix),canreview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("competencyid",prefix),competencyid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradename",prefix),gradename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iscancelreviewrequestallowed",prefix),iscancelreviewrequestallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isrequestreviewallowed",prefix),isrequestreviewallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isstartreviewallowed",prefix),isstartreviewallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isstatusidle",prefix),isstatusidle.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isstatusinreview",prefix),isstatusinreview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isstatuswaitingforreview",prefix),isstatuswaitingforreview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isstopreviewallowed",prefix),isstopreviewallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("proficiency",prefix),proficiency.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("proficiencyname",prefix),proficiencyname));
			var reviewerItems = reviewer.ToKeyValuePairs("reviewer");
			keyValuePairs.AddRange(reviewerItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewerid",prefix),reviewerid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("statusname",prefix),statusname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			return keyValuePairs;
		}

	}
}
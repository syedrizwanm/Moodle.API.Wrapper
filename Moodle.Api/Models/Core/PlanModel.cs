using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class PlanModel : IModel 
	{
		public int canbeedited {get;set;}
		public int canmanage {get;set;}
		public int canrequestreview {get;set;}
		public int canreview {get;set;}
		public Commentarea commentarea {get;set;}
		public string description {get;set;}
		public int descriptionformat {get;set;}
		public int duedate {get;set;}
		public string duedateformatted {get;set;}
		public int id {get;set;}
		public int isactive {get;set;}
		public int isapproveallowed {get;set;}
		public int isbasedontemplate {get;set;}
		public int iscancelreviewrequestallowed {get;set;}
		public int iscompleteallowed {get;set;}
		public int iscompleted {get;set;}
		public int isdraft {get;set;}
		public int isinreview {get;set;}
		public int isreopenallowed {get;set;}
		public int isrequestreviewallowed {get;set;}
		public int isstartreviewallowed {get;set;}
		public int isstopreviewallowed {get;set;}
		public int isunapproveallowed {get;set;}
		public int isunlinkallowed {get;set;}
		public int iswaitingforreview {get;set;}
		public string name {get;set;}
		public int origtemplateid {get;set;}
		public Reviewer reviewer {get;set;}
		public int reviewerid {get;set;}
		public int status {get;set;}
		public string statusname {get;set;}
		public Template template {get;set;}
		public int templateid {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public string url {get;set;}
		public int userid {get;set;}
		public int usermodified {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canbeedited",prefix),canbeedited.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canmanage",prefix),canmanage.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canrequestreview",prefix),canrequestreview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canreview",prefix),canreview.ToString()));
			var commentareaItems = commentarea.ToKeyValuePairs("commentarea");
			keyValuePairs.AddRange(commentareaItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("duedate",prefix),duedate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("duedateformatted",prefix),duedateformatted));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isactive",prefix),isactive.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isapproveallowed",prefix),isapproveallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isbasedontemplate",prefix),isbasedontemplate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iscancelreviewrequestallowed",prefix),iscancelreviewrequestallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iscompleteallowed",prefix),iscompleteallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iscompleted",prefix),iscompleted.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isdraft",prefix),isdraft.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isinreview",prefix),isinreview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isreopenallowed",prefix),isreopenallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isrequestreviewallowed",prefix),isrequestreviewallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isstartreviewallowed",prefix),isstartreviewallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isstopreviewallowed",prefix),isstopreviewallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isunapproveallowed",prefix),isunapproveallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("isunlinkallowed",prefix),isunlinkallowed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("iswaitingforreview",prefix),iswaitingforreview.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("name",prefix),name));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("origtemplateid",prefix),origtemplateid.ToString()));
			var reviewerItems = reviewer.ToKeyValuePairs("reviewer");
			keyValuePairs.AddRange(reviewerItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reviewerid",prefix),reviewerid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("status",prefix),status.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("statusname",prefix),statusname));
			var templateItems = template.ToKeyValuePairs("template");
			keyValuePairs.AddRange(templateItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("templateid",prefix),templateid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			return keyValuePairs;
		}

	}
}
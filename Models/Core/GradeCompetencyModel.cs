using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class GradeCompetencyModel : IModel 
	{
		public int action {get;set;}
		public Actionuser actionuser {get;set;}
		public int actionuserid {get;set;}
		public int candelete {get;set;}
		public int contextid {get;set;}
		public string desca {get;set;}
		public string desccomponent {get;set;}
		public string descidentifier {get;set;}
		public string description {get;set;}
		public int grade {get;set;}
		public string gradename {get;set;}
		public int id {get;set;}
		public string note {get;set;}
		public int timecreated {get;set;}
		public int timemodified {get;set;}
		public string url {get;set;}
		public int usercompetencyid {get;set;}
		public string userdate {get;set;}
		public int usermodified {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("action",prefix),action.ToString()));
			var actionuserItems = actionuser.ToKeyValuePairs("actionuser");
			keyValuePairs.AddRange(actionuserItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("actionuserid",prefix),actionuserid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("candelete",prefix),candelete.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextid",prefix),contextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("desca",prefix),desca));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("desccomponent",prefix),desccomponent));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descidentifier",prefix),descidentifier));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grade",prefix),grade.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradename",prefix),gradename));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("note",prefix),note));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timecreated",prefix),timecreated.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timemodified",prefix),timemodified.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("url",prefix),url));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usercompetencyid",prefix),usercompetencyid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userdate",prefix),userdate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usermodified",prefix),usermodified.ToString()));
			return keyValuePairs;
		}

	}
}
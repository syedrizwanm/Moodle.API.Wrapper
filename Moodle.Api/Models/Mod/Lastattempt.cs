using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Lastattempt : IModel 
	{

		public int blindmarking {get;set;}
		public int canedit {get;set;}
		public int caneditowner {get;set;}
		public int cansubmit {get;set;}
		public int extensionduedate {get;set;}
		public int graded {get;set;}
		public string gradingstatus {get;set;}
		public int locked {get;set;}
		public Submission submission {get;set;}
		public int submissiongroup {get;set;}
		public List<int> submissiongroupmemberswhoneedtosubmit {get;set;}
		public int submissionsenabled {get;set;}
		public Teamsubmission teamsubmission {get;set;}
		public List<int> usergroups {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("blindmarking",prefix),blindmarking.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("canedit",prefix),canedit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("caneditowner",prefix),caneditowner.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cansubmit",prefix),cansubmit.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("extensionduedate",prefix),extensionduedate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("graded",prefix),graded.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("gradingstatus",prefix),gradingstatus));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("locked",prefix),locked.ToString()));
			var submissionItems = submission.ToKeyValuePairs("submission");
			keyValuePairs.AddRange(submissionItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("submissiongroup",prefix),submissiongroup.ToString()));

			for(var submissiongroupmemberswhoneedtosubmitIndex = 0; submissiongroupmemberswhoneedtosubmitIndex<submissiongroupmemberswhoneedtosubmit.Count;submissiongroupmemberswhoneedtosubmitIndex++) 
			{
				var submissiongroupmemberswhoneedtosubmitItem = submissiongroupmemberswhoneedtosubmit[submissiongroupmemberswhoneedtosubmitIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("submissiongroupmemberswhoneedtosubmit[" + submissiongroupmemberswhoneedtosubmitIndex + "]",prefix), submissiongroupmemberswhoneedtosubmitItem.ToString()));
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("submissionsenabled",prefix),submissionsenabled.ToString()));
			var teamsubmissionItems = teamsubmission.ToKeyValuePairs("teamsubmission");
			keyValuePairs.AddRange(teamsubmissionItems);

			for(var usergroupsIndex = 0; usergroupsIndex<usergroups.Count;usergroupsIndex++) 
			{
				var usergroupsItem = usergroups[usergroupsIndex];
				keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("usergroups[" + usergroupsIndex + "]",prefix), usergroupsItem.ToString()));
			}

			return keyValuePairs;
		}

	}
}
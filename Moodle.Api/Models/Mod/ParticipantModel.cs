using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ParticipantModel : IModel 
	{
		public int allowsubmissionsfromdate {get;set;}
		public int blindmarking {get;set;}
		public int cutoffdate {get;set;}
		public int duedate {get;set;}
		public string duedatestr {get;set;}
		public string fullname {get;set;}
		public int grantedextension {get;set;}
		public int groupid {get;set;}
		public string groupname {get;set;}
		public int id {get;set;}
		public int requiregrading {get;set;}
		public int submitted {get;set;}
		public User user {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("allowsubmissionsfromdate",prefix),allowsubmissionsfromdate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("blindmarking",prefix),blindmarking.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("cutoffdate",prefix),cutoffdate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("duedate",prefix),duedate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("duedatestr",prefix),duedatestr));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("fullname",prefix),fullname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grantedextension",prefix),grantedextension.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupname",prefix),groupname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("requiregrading",prefix),requiregrading.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("submitted",prefix),submitted.ToString()));
			var userItems = user.ToKeyValuePairs("user");
			keyValuePairs.AddRange(userItems);
			return keyValuePairs;
		}

	}
}
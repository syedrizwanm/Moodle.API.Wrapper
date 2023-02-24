using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Userflag : IModel 
	{

		public int allocatedmarker {get;set;}
		public int extensionduedate {get;set;}
		public int id {get;set;}
		public int locked {get;set;}
		public int mailed {get;set;}
		public int userid {get;set;}
		public string workflowstate {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("allocatedmarker",prefix),allocatedmarker.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("extensionduedate",prefix),extensionduedate.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("locked",prefix),locked.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mailed",prefix),mailed.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("workflowstate",prefix),workflowstate));
			return keyValuePairs;
		}

	}
}
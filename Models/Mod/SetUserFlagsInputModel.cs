using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SetUserFlagsInputModel : IModel 
	{
		public int assignmentid {get;set;}
		public List<UserflagInputModel> userflags {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignmentid",prefix),assignmentid.ToString()));

			for(var userflagsIndex = 0; userflagsIndex<userflags.Count;userflagsIndex++) 
			{
				var userflagsItem = userflags[userflagsIndex];
				var userflagsItems = userflagsItem.ToKeyValuePairs("userflags[" + userflagsIndex + "]");
				keyValuePairs.AddRange(userflagsItems);
			}

			return keyValuePairs;
		}

	}
}
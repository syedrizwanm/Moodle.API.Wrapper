using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DataForMessageareaMessagesInputModel : IModel 
	{
		public int currentuserid {get;set;}
		public int limitfrom {get;set;}
		public int limitnum {get;set;}
		public int newest {get;set;}
		public int otheruserid {get;set;}
		public int timefrom {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("currentuserid",prefix),currentuserid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitfrom",prefix),limitfrom.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("limitnum",prefix),limitnum.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("newest",prefix),newest.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("otheruserid",prefix),otheruserid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("timefrom",prefix),timefrom.ToString()));
			return keyValuePairs;
		}

	}
}
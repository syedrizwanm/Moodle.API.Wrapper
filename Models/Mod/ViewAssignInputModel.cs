using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewAssignInputModel : IModel 
	{
		public int assignid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("assignid",prefix),assignid.ToString()));
			return keyValuePairs;
		}

	}
}
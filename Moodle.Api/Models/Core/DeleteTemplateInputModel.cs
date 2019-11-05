using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class DeleteTemplateInputModel : IModel 
	{
		public int deleteplans {get;set;}
		public int id {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("deleteplans",prefix),deleteplans.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			return keyValuePairs;
		}

	}
}
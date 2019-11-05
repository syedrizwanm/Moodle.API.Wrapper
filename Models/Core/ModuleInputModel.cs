using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ModuleInputModel : IModel 
	{
		public int id {get;set;}
		public int sectionreturn {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sectionreturn",prefix),sectionreturn.ToString()));
			return keyValuePairs;
		}

	}
}
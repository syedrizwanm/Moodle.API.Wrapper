using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewGlossaryInputModel : IModel 
	{
		public int id {get;set;}
		public string mode {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("mode",prefix),mode));
			return keyValuePairs;
		}

	}
}
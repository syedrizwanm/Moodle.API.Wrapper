using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ChoiceOptionsInputModel : IModel 
	{
		public int choiceid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("choiceid",prefix),choiceid.ToString()));
			return keyValuePairs;
		}

	}
}
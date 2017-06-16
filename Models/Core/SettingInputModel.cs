using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class SettingInputModel : IModel 
	{

		public int pushratingstouserplans {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pushratingstouserplans",prefix),pushratingstouserplans.ToString()));
			return keyValuePairs;
		}

	}
}
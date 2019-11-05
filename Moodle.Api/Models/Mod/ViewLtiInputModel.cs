using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewLtiInputModel : IModel 
	{
		public int ltiid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ltiid",prefix),ltiid.ToString()));
			return keyValuePairs;
		}

	}
}
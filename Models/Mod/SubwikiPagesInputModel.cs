using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class SubwikiPagesInputModel : IModel 
	{
		public int groupid {get;set;}
		public OptionInputModel options {get;set;}
		public int userid {get;set;}
		public int wikiid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("groupid",prefix),groupid.ToString()));
			var optionsItems = options.ToKeyValuePairs("options");
			keyValuePairs.AddRange(optionsItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("userid",prefix),userid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("wikiid",prefix),wikiid.ToString()));
			return keyValuePairs;
		}

	}
}
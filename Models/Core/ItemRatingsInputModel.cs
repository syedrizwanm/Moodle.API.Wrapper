using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class ItemRatingsInputModel : IModel 
	{
		public string component {get;set;}
		public string contextlevel {get;set;}
		public int instanceid {get;set;}
		public int itemid {get;set;}
		public string ratingarea {get;set;}
		public int scaleid {get;set;}
		public string sort {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextlevel",prefix),contextlevel));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instanceid",prefix),instanceid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ratingarea",prefix),ratingarea));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleid",prefix),scaleid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sort",prefix),sort));
			return keyValuePairs;
		}

	}
}
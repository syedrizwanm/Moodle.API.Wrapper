using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class RatingInputModel : IModel 
	{
		public int aggregation {get;set;}
		public string component {get;set;}
		public string contextlevel {get;set;}
		public int instanceid {get;set;}
		public int itemid {get;set;}
		public int rateduserid {get;set;}
		public int rating {get;set;}
		public string ratingarea {get;set;}
		public int scaleid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("aggregation",prefix),aggregation.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("component",prefix),component));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contextlevel",prefix),contextlevel));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("instanceid",prefix),instanceid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rateduserid",prefix),rateduserid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("rating",prefix),rating.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("ratingarea",prefix),ratingarea));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("scaleid",prefix),scaleid.ToString()));
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class Guide_CriteriaInputModel : IModel 
	{

		public string description {get;set;}
		public int descriptionformat {get;set;}
		public string descriptionmarkers {get;set;}
		public int descriptionmarkersformat {get;set;}
		public int id {get;set;}
		public double maxscore {get;set;}
		public string shortname {get;set;}
		public int sortorder {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("description",prefix),description));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionformat",prefix),descriptionformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionmarkers",prefix),descriptionmarkers));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("descriptionmarkersformat",prefix),descriptionmarkersformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("maxscore",prefix),maxscore.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("shortname",prefix),shortname));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortorder",prefix),sortorder.ToString()));
			return keyValuePairs;
		}

	}
}
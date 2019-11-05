using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class FillingInputModel : IModel 
	{

		public int criterionid {get;set;}
		public int levelid {get;set;}
		public string remark {get;set;}
		public int remarkformat {get;set;}
		public double score {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("criterionid",prefix),criterionid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("levelid",prefix),levelid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("remark",prefix),remark));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("remarkformat",prefix),remarkformat.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("score",prefix),score.ToString()));
			return keyValuePairs;
		}

	}
}
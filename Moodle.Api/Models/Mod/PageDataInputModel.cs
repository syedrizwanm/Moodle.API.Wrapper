using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class PageDataInputModel : IModel 
	{
		public int lessonid {get;set;}
		public int pageid {get;set;}
		public string password {get;set;}
		public int returncontents {get;set;}
		public int review {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("lessonid",prefix),lessonid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pageid",prefix),pageid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("password",prefix),password));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("returncontents",prefix),returncontents.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("review",prefix),review.ToString()));
			return keyValuePairs;
		}

	}
}
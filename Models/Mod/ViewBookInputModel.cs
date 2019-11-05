using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class ViewBookInputModel : IModel 
	{
		public int bookid {get;set;}
		public int chapterid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("bookid",prefix),bookid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("chapterid",prefix),chapterid.ToString()));
			return keyValuePairs;
		}

	}
}
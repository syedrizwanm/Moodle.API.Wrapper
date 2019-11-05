using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Answerpage : IModel 
	{

		public Answerdata answerdata {get;set;}
		public string contents {get;set;}
		public int grayout {get;set;}
		public string qtype {get;set;}
		public string title {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			var answerdataItems = answerdata.ToKeyValuePairs("answerdata");
			keyValuePairs.AddRange(answerdataItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("contents",prefix),contents));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("grayout",prefix),grayout.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("qtype",prefix),qtype));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("title",prefix),title));
			return keyValuePairs;
		}

	}
}
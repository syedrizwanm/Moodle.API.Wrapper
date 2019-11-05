using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class Step : IModel 
	{

		public int backdrop {get;set;}
		public string content {get;set;}
		public int delay {get;set;}
		public string element {get;set;}
		public int orphan {get;set;}
		public string placement {get;set;}
		public int reflex {get;set;}
		public int stepid {get;set;}
		public string title {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("backdrop",prefix),backdrop.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("content",prefix),content));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("delay",prefix),delay.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("element",prefix),element));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("orphan",prefix),orphan.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("placement",prefix),placement));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("reflex",prefix),reflex.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("stepid",prefix),stepid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("title",prefix),title));
			return keyValuePairs;
		}

	}
}
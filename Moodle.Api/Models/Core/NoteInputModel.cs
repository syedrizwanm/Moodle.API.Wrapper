using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class NoteInputModel : IModel 
	{

		public int format {get;set;}
		public int id {get;set;}
		public string publishstate {get;set;}
		public string text {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("format",prefix),format.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("publishstate",prefix),publishstate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));
			return keyValuePairs;
		}

	}
}
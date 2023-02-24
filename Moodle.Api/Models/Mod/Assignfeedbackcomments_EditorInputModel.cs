using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class Assignfeedbackcomments_EditorInputModel : IModel 
	{

		public int format {get;set;}
		public string text {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("format",prefix),format.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("text",prefix),text));
			return keyValuePairs;
		}

	}
}
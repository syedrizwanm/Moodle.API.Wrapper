using System.Collections.Generic;

namespace Moodle.Api.Models.Tool
{
	public sealed class DataForUserEvidencePageModel : IModel 
	{

		public string pluginbaseurl {get;set;}
		public Userevidence userevidence {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pluginbaseurl",prefix),pluginbaseurl));
			var userevidenceItems = userevidence.ToKeyValuePairs("userevidence");
			keyValuePairs.AddRange(userevidenceItems);
			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class PictureModel : IModel 
	{
		public string profileimageurl {get;set;}
		public int success {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("profileimageurl",prefix),profileimageurl));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("success",prefix),success.ToString()));

			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}
using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class AuthorsModel : IModel 
	{
		public List<Author> authors {get;set;}
		public int count {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var authorsIndex = 0; authorsIndex<authors.Count;authorsIndex++) 
			{
				var authorsItem = authors[authorsIndex];
				var authorsItems = authorsItem.ToKeyValuePairs("authors[" + authorsIndex + "]");
				keyValuePairs.AddRange(authorsItems);
			}

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("count",prefix),count.ToString()));

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
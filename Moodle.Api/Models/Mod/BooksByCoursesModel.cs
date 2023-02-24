using System.Collections.Generic;

namespace Moodle.Api.Models.Mod
{
	public sealed class BooksByCoursesModel : IModel 
	{
		public List<Book> books {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var booksIndex = 0; booksIndex<books.Count;booksIndex++) 
			{
				var booksItem = books[booksIndex];
				var booksItems = booksItem.ToKeyValuePairs("books[" + booksIndex + "]");
				keyValuePairs.AddRange(booksItems);
			}


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
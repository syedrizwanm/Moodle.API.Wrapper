using System.Collections.Generic;

namespace Moodle.Api.Models.Core
{
	public sealed class FilesModel : IModel 
	{
		public List<File> files {get;set;}
		public List<Parent> parents {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var filesIndex = 0; filesIndex<files.Count;filesIndex++) 
			{
				var filesItem = files[filesIndex];
				var filesItems = filesItem.ToKeyValuePairs("files[" + filesIndex + "]");
				keyValuePairs.AddRange(filesItems);
			}


			for(var parentsIndex = 0; parentsIndex<parents.Count;parentsIndex++) 
			{
				var parentsItem = parents[parentsIndex];
				var parentsItems = parentsItem.ToKeyValuePairs("parents[" + parentsIndex + "]");
				keyValuePairs.AddRange(parentsItems);
			}

			return keyValuePairs;
		}

	}
}